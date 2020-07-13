//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by DOTS Input Device Code Generator
//     version 1.1.0
//     from SwitchProControllerHID Layout
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;
using Unity.Input;

#pragma warning disable CS0169

namespace Unity.Input
{
    public struct SwitchProControllerHIDEvent : IInputData
    {
        public enum Id : uint
        {
            ButtonSouth = 8,
            ButtonEast = 9,
            ButtonWest = 10,
            ButtonNorth = 11,
            LeftShoulder = 12,
            RightShoulder = 13,
            LeftTrigger = 14,
            RightTrigger = 15,
            Select = 16,
            Start = 17,
            LeftStickPress = 18,
            RightStickPress = 19,
            DpadUp = 24,
            DpadDown = 24,
            DpadLeft = 24,
            DpadRight = 24,
            LeftStickX = 32,
            LeftStickY = 48,
            RightStickX = 64,
            RightStickY = 80,
        }

        private int Padding0;
        public ushort LeftStickX;
        public ushort LeftStickY;
        public ushort RightStickX;
        public ushort RightStickY;

        public unsafe bool ButtonSouth
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[1] & ((1 << 0) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[1] |= (1 << 0) & 0xFF;
                else
                    ((byte*)thisPtr)[1] &= ~(1 << 0) & 0xFF;
            }
        }

        public unsafe bool ButtonEast
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[1] & ((1 << 1) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[1] |= (1 << 1) & 0xFF;
                else
                    ((byte*)thisPtr)[1] &= ~(1 << 1) & 0xFF;
            }
        }

        public unsafe bool ButtonWest
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[1] & ((1 << 2) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[1] |= (1 << 2) & 0xFF;
                else
                    ((byte*)thisPtr)[1] &= ~(1 << 2) & 0xFF;
            }
        }

        public unsafe bool ButtonNorth
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[1] & ((1 << 3) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[1] |= (1 << 3) & 0xFF;
                else
                    ((byte*)thisPtr)[1] &= ~(1 << 3) & 0xFF;
            }
        }

        public unsafe bool LeftShoulder
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[1] & ((1 << 4) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[1] |= (1 << 4) & 0xFF;
                else
                    ((byte*)thisPtr)[1] &= ~(1 << 4) & 0xFF;
            }
        }

        public unsafe bool RightShoulder
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[1] & ((1 << 5) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[1] |= (1 << 5) & 0xFF;
                else
                    ((byte*)thisPtr)[1] &= ~(1 << 5) & 0xFF;
            }
        }

        public unsafe bool LeftTrigger
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[1] & ((1 << 6) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[1] |= (1 << 6) & 0xFF;
                else
                    ((byte*)thisPtr)[1] &= ~(1 << 6) & 0xFF;
            }
        }

        public unsafe bool RightTrigger
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[1] & ((1 << 7) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[1] |= (1 << 7) & 0xFF;
                else
                    ((byte*)thisPtr)[1] &= ~(1 << 7) & 0xFF;
            }
        }

        public unsafe bool Select
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[2] & ((1 << 0) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[2] |= (1 << 0) & 0xFF;
                else
                    ((byte*)thisPtr)[2] &= ~(1 << 0) & 0xFF;
            }
        }

        public unsafe bool Start
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[2] & ((1 << 1) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[2] |= (1 << 1) & 0xFF;
                else
                    ((byte*)thisPtr)[2] &= ~(1 << 1) & 0xFF;
            }
        }

        public unsafe bool LeftStickPress
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[2] & ((1 << 2) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[2] |= (1 << 2) & 0xFF;
                else
                    ((byte*)thisPtr)[2] &= ~(1 << 2) & 0xFF;
            }
        }

        public unsafe bool RightStickPress
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[2] & ((1 << 3) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[2] |= (1 << 3) & 0xFF;
                else
                    ((byte*)thisPtr)[2] &= ~(1 << 3) & 0xFF;
            }
        }

        public uint Format => 3785857748;

        public DOTSInput.InputPipeline InputPipelineParts
        {
            get
            {
                var structMappings = new NativeArray<DOTSInput.InputStructMapping>(kStructMappingCount, Allocator.Persistent);
                var transforms = new NativeArray<DOTSInput.InputTransform>(kTransformCount, Allocator.Persistent);


                // SwitchProControllerHIDEvent -> SwitchProControllerHIDInput
                transforms[0] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.ButtonSouth,
                    OutputId = (uint)SwitchProControllerHIDInput.Id.ButtonSouth
                };
                transforms[1] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.ButtonEast,
                    OutputId = (uint)SwitchProControllerHIDInput.Id.ButtonEast
                };
                transforms[2] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.ButtonWest,
                    OutputId = (uint)SwitchProControllerHIDInput.Id.ButtonWest
                };
                transforms[3] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.ButtonNorth,
                    OutputId = (uint)SwitchProControllerHIDInput.Id.ButtonNorth
                };
                transforms[4] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.LeftShoulder,
                    OutputId = (uint)SwitchProControllerHIDInput.Id.LeftShoulder
                };
                transforms[5] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.RightShoulder,
                    OutputId = (uint)SwitchProControllerHIDInput.Id.RightShoulder
                };
                transforms[6] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.LeftTrigger,
                    OutputId = (uint)SwitchProControllerHIDInput.Id.LeftTrigger
                };
                transforms[7] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.RightTrigger,
                    OutputId = (uint)SwitchProControllerHIDInput.Id.RightTrigger
                };
                transforms[8] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.Select,
                    OutputId = (uint)SwitchProControllerHIDInput.Id.Select
                };
                transforms[9] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.Start,
                    OutputId = (uint)SwitchProControllerHIDInput.Id.Start
                };
                transforms[10] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.LeftStickPress,
                    OutputId = (uint)SwitchProControllerHIDInput.Id.LeftStickPress
                };
                transforms[11] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.RightStickPress,
                    OutputId = (uint)SwitchProControllerHIDInput.Id.RightStickPress
                };
                structMappings[0] = new DOTSInput.InputStructMapping
                {
                    InputFormat = 3785857748,
                    OutputFormat = 2160464754,
                    InputSizeInBytes = (uint)UnsafeUtility.SizeOf<SwitchProControllerHIDEvent>(),
                    OutputSizeInBytes = (uint)UnsafeUtility.SizeOf<SwitchProControllerHIDInput>(),
                    TransformStartIndex = 0,
                    TransformCount = 12
                };

                // SwitchProControllerHIDEvent -> GamepadInput
                transforms[12] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.ButtonSouth,
                    OutputId = (uint)GamepadInput.Id.ButtonSouth
                };
                transforms[13] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.ButtonEast,
                    OutputId = (uint)GamepadInput.Id.ButtonEast
                };
                transforms[14] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.ButtonWest,
                    OutputId = (uint)GamepadInput.Id.ButtonWest
                };
                transforms[15] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.ButtonNorth,
                    OutputId = (uint)GamepadInput.Id.ButtonNorth
                };
                transforms[16] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.LeftShoulder,
                    OutputId = (uint)GamepadInput.Id.LeftShoulder
                };
                transforms[17] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.RightShoulder,
                    OutputId = (uint)GamepadInput.Id.RightShoulder
                };
                transforms[18] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.LeftTrigger,
                    OutputId = (uint)GamepadInput.Id.LeftTrigger
                };
                transforms[19] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.RightTrigger,
                    OutputId = (uint)GamepadInput.Id.RightTrigger
                };
                transforms[20] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.Select,
                    OutputId = (uint)GamepadInput.Id.Select
                };
                transforms[21] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.Start,
                    OutputId = (uint)GamepadInput.Id.Start
                };
                transforms[22] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.LeftStickPress,
                    OutputId = (uint)GamepadInput.Id.LeftStickPress
                };
                transforms[23] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.RightStickPress,
                    OutputId = (uint)GamepadInput.Id.RightStickPress
                };
                structMappings[1] = new DOTSInput.InputStructMapping
                {
                    InputFormat = 3785857748,
                    OutputFormat = 623278190,
                    InputSizeInBytes = (uint)UnsafeUtility.SizeOf<SwitchProControllerHIDEvent>(),
                    OutputSizeInBytes = (uint)UnsafeUtility.SizeOf<GamepadInput>(),
                    TransformStartIndex = 12,
                    TransformCount = 12
                };

                return new DOTSInput.InputPipeline
                {
                    StructMappings = structMappings,
                    Transforms = transforms,
                };
            }
        }

        private const int kStructMappingCount = 2;
        private const int kTransformCount = 24;
    }

    public struct SwitchProControllerHIDInput : IComponentData, IInputData
    {
        public Float2Input Dpad;
        public Float2Input LeftStick;
        public Float2Input RightStick;
        public FloatInput DpadX;
        public FloatInput DpadY;
        public HalfAxisInput DpadUp;
        public HalfAxisInput DpadDown;
        public HalfAxisInput DpadLeft;
        public HalfAxisInput DpadRight;
        public HalfAxisInput LeftStickUp;
        public AxisInput LeftStickX;
        public AxisInput LeftStickY;
        public HalfAxisInput LeftStickDown;
        public HalfAxisInput LeftStickLeft;
        public HalfAxisInput LeftStickRight;
        public HalfAxisInput RightStickUp;
        public AxisInput RightStickX;
        public AxisInput RightStickY;
        public HalfAxisInput RightStickDown;
        public HalfAxisInput RightStickLeft;
        public HalfAxisInput RightStickRight;
        public ButtonInput ButtonNorth;
        public ButtonInput ButtonSouth;
        public ButtonInput ButtonWest;
        public ButtonInput ButtonEast;
        public ButtonInput LeftStickPress;
        public ButtonInput RightStickPress;
        public ButtonInput LeftShoulder;
        public ButtonInput RightShoulder;
        public ButtonInput LeftTrigger;
        public ButtonInput RightTrigger;
        public ButtonInput Start;
        public ButtonInput Select;
        public ButtonInput ButtonDpadUp;
        public ButtonInput ButtonDpadDown;
        public ButtonInput ButtonDpadLeft;
        public ButtonInput ButtonDpadRight;
        public ButtonInput ButtonLeftStickUp;
        public ButtonInput ButtonLeftStickDown;
        public ButtonInput ButtonLeftStickLeft;
        public ButtonInput ButtonLeftStickRight;
        public ButtonInput ButtonRightStickUp;
        public ButtonInput ButtonRightStickDown;
        public ButtonInput ButtonRightStickLeft;
        public ButtonInput ButtonRightStickRight;

        public enum Id : uint
        {
            Dpad = 0,
            LeftStick = 64,
            RightStick = 128,
            DpadX = 192,
            DpadY = 224,
            DpadUp = 256,
            DpadDown = 288,
            DpadLeft = 320,
            DpadRight = 352,
            LeftStickUp = 384,
            LeftStickX = 416,
            LeftStickY = 448,
            LeftStickDown = 480,
            LeftStickLeft = 512,
            LeftStickRight = 544,
            RightStickUp = 576,
            RightStickX = 608,
            RightStickY = 640,
            RightStickDown = 672,
            RightStickLeft = 704,
            RightStickRight = 736,
            ButtonNorth = 768,
            ButtonSouth = 776,
            ButtonWest = 784,
            ButtonEast = 792,
            LeftStickPress = 800,
            RightStickPress = 808,
            LeftShoulder = 816,
            RightShoulder = 824,
            LeftTrigger = 832,
            RightTrigger = 840,
            Start = 848,
            Select = 856,
            ButtonDpadUp = 864,
            ButtonDpadDown = 872,
            ButtonDpadLeft = 880,
            ButtonDpadRight = 888,
            ButtonLeftStickUp = 896,
            ButtonLeftStickDown = 904,
            ButtonLeftStickLeft = 912,
            ButtonLeftStickRight = 920,
            ButtonRightStickUp = 928,
            ButtonRightStickDown = 936,
            ButtonRightStickLeft = 944,
            ButtonRightStickRight = 952,
        }
        public uint Format => 2160464754;

        public DOTSInput.InputPipeline InputPipelineParts
        {
            get
            {
                var structMappings = kStructMappingCount > 0 ? new NativeArray<DOTSInput.InputStructMapping>(kStructMappingCount, Allocator.Persistent) : default;
                var transforms = kTransformCount > 0 ? new NativeArray<DOTSInput.InputTransform>(kTransformCount, Allocator.Persistent) : default;

                transforms[0] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Combination.TwoAxesToOneFloat2),
                    InputId1 = (uint)Id.DpadX,
                    InputId2 = (uint)Id.DpadY,
                    OutputId = (uint)Id.Dpad
                };
                transforms[1] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Combination.TwoAxesToOneFloat2),
                    InputId1 = (uint)Id.LeftStickX,
                    InputId2 = (uint)Id.LeftStickY,
                    OutputId = (uint)Id.LeftStick
                };
                transforms[2] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Combination.TwoAxesToOneFloat2),
                    InputId1 = (uint)Id.RightStickX,
                    InputId2 = (uint)Id.RightStickY,
                    OutputId = (uint)Id.RightStick
                };
                transforms[3] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.PositiveAxisToHalfAxis),
                    InputId1 = (uint)Id.LeftStickY,
                    OutputId = (uint)Id.LeftStickUp
                };
                transforms[4] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.HalfAxisToButton),
                    InputId1 = (uint)Id.LeftStickUp,
                    OutputId = (uint)Id.ButtonLeftStickUp
                };
                transforms[5] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.NegativeAxisToHalfAxis),
                    InputId1 = (uint)Id.LeftStickY,
                    OutputId = (uint)Id.LeftStickDown
                };
                transforms[6] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.HalfAxisToButton),
                    InputId1 = (uint)Id.LeftStickDown,
                    OutputId = (uint)Id.ButtonLeftStickDown
                };
                transforms[7] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.NegativeAxisToHalfAxis),
                    InputId1 = (uint)Id.LeftStickX,
                    OutputId = (uint)Id.LeftStickLeft
                };
                transforms[8] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.HalfAxisToButton),
                    InputId1 = (uint)Id.LeftStickLeft,
                    OutputId = (uint)Id.ButtonLeftStickLeft
                };
                transforms[9] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.PositiveAxisToHalfAxis),
                    InputId1 = (uint)Id.LeftStickX,
                    OutputId = (uint)Id.LeftStickRight
                };
                transforms[10] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.HalfAxisToButton),
                    InputId1 = (uint)Id.LeftStickRight,
                    OutputId = (uint)Id.ButtonLeftStickRight
                };
                transforms[11] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.PositiveAxisToHalfAxis),
                    InputId1 = (uint)Id.RightStickY,
                    OutputId = (uint)Id.RightStickUp
                };
                transforms[12] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.HalfAxisToButton),
                    InputId1 = (uint)Id.RightStickUp,
                    OutputId = (uint)Id.ButtonRightStickUp
                };
                transforms[13] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.NegativeAxisToHalfAxis),
                    InputId1 = (uint)Id.RightStickY,
                    OutputId = (uint)Id.RightStickDown
                };
                transforms[14] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.HalfAxisToButton),
                    InputId1 = (uint)Id.RightStickDown,
                    OutputId = (uint)Id.ButtonRightStickDown
                };
                transforms[15] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.NegativeAxisToHalfAxis),
                    InputId1 = (uint)Id.RightStickX,
                    OutputId = (uint)Id.RightStickLeft
                };
                transforms[16] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.HalfAxisToButton),
                    InputId1 = (uint)Id.RightStickLeft,
                    OutputId = (uint)Id.ButtonRightStickLeft
                };
                transforms[17] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.PositiveAxisToHalfAxis),
                    InputId1 = (uint)Id.RightStickX,
                    OutputId = (uint)Id.RightStickRight
                };
                transforms[18] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.HalfAxisToButton),
                    InputId1 = (uint)Id.RightStickRight,
                    OutputId = (uint)Id.ButtonRightStickRight
                };

                structMappings[0] = new DOTSInput.InputStructMapping
                {
                    InputFormat = 2160464754,
                    OutputFormat = 2160464754,
                    InputSizeInBytes = (uint)UnsafeUtility.SizeOf<SwitchProControllerHIDInput>(),
                    OutputSizeInBytes = (uint)UnsafeUtility.SizeOf<SwitchProControllerHIDInput>(),
                    TransformStartIndex = 0,
                    TransformCount = 19
                };
                return new DOTSInput.InputPipeline
                {
                    StructMappings = structMappings,
                    Transforms = transforms,
                };
            }
        }

        private const int kStructMappingCount = 1;
        private const int kTransformCount = 19;
    }
}
