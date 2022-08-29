#if UNITY_EDITOR && UNITY_2022_1_OR_NEWER
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine.InputSystem.Editor.Lists;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Editor
{
    internal delegate InputActionsEditorState Command(in InputActionsEditorState state);

    internal static class Commands
    {
        public static Command SelectAction(string actionName)
        {
            return (in InputActionsEditorState state) => state.SelectAction(actionName);
        }

        public static Command SelectActionMap(string actionMapName)
        {
            return (in InputActionsEditorState state) => state.SelectActionMap(actionMapName);
        }

        public static Command ExpandCompositeBinding(SerializedInputBinding binding)
        {
            return (in InputActionsEditorState state) => state.ExpandCompositeBinding(binding);
        }

        public static Command CollapseCompositeBinding(SerializedInputBinding binding)
        {
            return (in InputActionsEditorState state) => state.CollapseCompositeBinding(binding);
        }

        public static Command SelectBinding(SerializedInputBinding binding)
        {
            return (in InputActionsEditorState state) =>
                state.With(selectedBindingIndex: binding.indexOfBinding, selectionType: SelectionType.Binding);
        }

        public static Command UpdatePathNameAndValues(NamedValue[] parameters, SerializedProperty pathProperty)
        {
            return (in InputActionsEditorState state) =>
            {
                var path = pathProperty.stringValue;
                var nameAndParameters = NameAndParameters.Parse(path);
                nameAndParameters.parameters = parameters;

                pathProperty.stringValue = nameAndParameters.ToString();
                state.serializedObject.ApplyModifiedProperties();
                return state;
            };
        }

        public static Command SetCompositeBindingType(SerializedInputBinding bindingProperty, IEnumerable<string> compositeTypes,
            ParameterListView parameterListView, int selectedCompositeTypeIndex)
        {
            return (in InputActionsEditorState state) =>
            {
                var nameAndParameters = new NameAndParameters
                {
                    name = compositeTypes.ElementAt(selectedCompositeTypeIndex),
                    parameters = parameterListView.GetParameters()
                };
                InputActionSerializationHelpers.ChangeCompositeBindingType(bindingProperty.wrappedProperty, nameAndParameters);
                state.serializedObject.ApplyModifiedProperties();
                return state;
            };
        }

        public static Command SetCompositeBindingPartName(SerializedInputBinding bindingProperty, string partName)
        {
            return (in InputActionsEditorState state) =>
            {
                InputActionSerializationHelpers.ChangeBinding(bindingProperty.wrappedProperty, partName);
                state.serializedObject.ApplyModifiedProperties();
                return state;
            };
        }

        public static Command ChangeActionType(SerializedInputAction inputAction, InputActionType newValue)
        {
            return (in InputActionsEditorState state) =>
            {
                inputAction.wrappedProperty.FindPropertyRelative(nameof(InputAction.m_Type)).intValue = (int)newValue;
                state.serializedObject.ApplyModifiedProperties();
                return state;
            };
        }

        public static Command ChangeInitialStateCheck(SerializedInputAction inputAction, bool value)
        {
            return (in InputActionsEditorState state) =>
            {
                var property = inputAction.wrappedProperty.FindPropertyRelative(nameof(InputAction.m_Flags));
                if (value)
                    property.intValue |= (int)InputAction.ActionFlags.WantsInitialStateCheck;
                else
                    property.intValue &= ~(int)InputAction.ActionFlags.WantsInitialStateCheck;
                state.serializedObject.ApplyModifiedProperties();
                return state;
            };
        }

        public static Command ChangeActionControlType(SerializedInputAction inputAction, int controlTypeIndex)
        {
            return (in InputActionsEditorState state) =>
            {
                var controlTypes = Selectors.BuildSortedControlList(inputAction.type).ToList();
                inputAction.wrappedProperty.FindPropertyRelative(nameof(InputAction.m_ExpectedControlType)).stringValue = controlTypes[controlTypeIndex];
                state.serializedObject.ApplyModifiedProperties();
                return state;
            };
        }

        /// <summary>
        /// Exists to integrate with some existing UI stuff, like InputControlPathEditor
        /// </summary>
        /// <returns></returns>
        public static Command ApplyModifiedProperties()
        {
            return (in InputActionsEditorState state) =>
            {
                state.serializedObject.ApplyModifiedProperties();
                return state;
            };
        }
    }
}

#endif
