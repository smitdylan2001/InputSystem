//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by DOTS Input Device Code Generator
//     version 1.1.0
//     from LightSensor Layout
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
    public struct LightSensorEvent : IInputData
    {
        public enum Id : uint
        {
            LightLevel = 0,
        }

        public float LightLevel;

        public uint Format => 309743769;

        public DOTSInput.InputPipeline InputPipelineParts
        {
            get
            {
                var structMappings = new NativeArray<DOTSInput.InputStructMapping>(kStructMappingCount, Allocator.Persistent);
                var transforms = new NativeArray<DOTSInput.InputTransform>(kTransformCount, Allocator.Persistent);


                // LightSensorEvent -> LightSensorInput
                transforms[0] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.FloatToAxis),
                    InputId1 = (uint)Id.LightLevel,
                    OutputId = (uint)LightSensorInput.Id.LightLevel
                };
                structMappings[0] = new DOTSInput.InputStructMapping
                {
                    InputFormat = 309743769,
                    OutputFormat = 1930942783,
                    InputSizeInBytes = (uint)UnsafeUtility.SizeOf<LightSensorEvent>(),
                    OutputSizeInBytes = (uint)UnsafeUtility.SizeOf<LightSensorInput>(),
                    TransformStartIndex = 0,
                    TransformCount = 1
                };

                return new DOTSInput.InputPipeline
                {
                    StructMappings = structMappings,
                    Transforms = transforms,
                };
            }
        }

        private const int kStructMappingCount = 1;
        private const int kTransformCount = 1;
    }

    public struct LightSensorInput : IComponentData, IInputData
    {
        public FloatInput LightLevel;

        public enum Id : uint
        {
            LightLevel = 0,
        }
        public uint Format => 1930942783;

        public DOTSInput.InputPipeline InputPipelineParts
        {
            get
            {
                var structMappings = kStructMappingCount > 0 ? new NativeArray<DOTSInput.InputStructMapping>(kStructMappingCount, Allocator.Persistent) : default;
                var transforms = kTransformCount > 0 ? new NativeArray<DOTSInput.InputTransform>(kTransformCount, Allocator.Persistent) : default;

                return new DOTSInput.InputPipeline
                {
                    StructMappings = structMappings,
                    Transforms = transforms,
                };
            }
        }

        private const int kStructMappingCount = 0;
        private const int kTransformCount = 0;
    }
}
