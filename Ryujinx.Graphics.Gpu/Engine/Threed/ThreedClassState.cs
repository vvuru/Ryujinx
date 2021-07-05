﻿using Ryujinx.Common.Memory;
using Ryujinx.Graphics.GAL;
using Ryujinx.Graphics.Gpu.Engine.InlineToMemory;
using Ryujinx.Graphics.Gpu.Image;
using Ryujinx.Graphics.Gpu.State;

namespace Ryujinx.Graphics.Gpu.Engine.Threed
{
    unsafe struct ThreedClassState : IShadowState
    {
#pragma warning disable CS0649
        public uint SetObject;
        public int SetObjectClassId => (int)((SetObject >> 0) & 0xFFFF);
        public int SetObjectEngineId => (int)((SetObject >> 16) & 0x1F);
        public fixed uint Reserved04[63];
        public uint NoOperation;
        public uint SetNotifyA;
        public int SetNotifyAAddressUpper => (int)((SetNotifyA >> 0) & 0xFF);
        public uint SetNotifyB;
        public uint Notify;
        public NotifyType NotifyType => (NotifyType)(Notify);
        public uint WaitForIdle;
        public uint LoadMmeInstructionRamPointer;
        public uint LoadMmeInstructionRam;
        public uint LoadMmeStartAddressRamPointer;
        public uint LoadMmeStartAddressRam;
        public uint SetMmeShadowRamControl;
        public SetMmeShadowRamControlMode SetMmeShadowRamControlMode => (SetMmeShadowRamControlMode)((SetMmeShadowRamControl >> 0) & 0x3);
        public fixed uint Reserved128[2];
        public uint SetGlobalRenderEnableA;
        public int SetGlobalRenderEnableAOffsetUpper => (int)((SetGlobalRenderEnableA >> 0) & 0xFF);
        public uint SetGlobalRenderEnableB;
        public uint SetGlobalRenderEnableC;
        public int SetGlobalRenderEnableCMode => (int)((SetGlobalRenderEnableC >> 0) & 0x7);
        public uint SendGoIdle;
        public uint PmTrigger;
        public uint PmTriggerWfi;
        public fixed uint Reserved148[2];
        public uint SetInstrumentationMethodHeader;
        public uint SetInstrumentationMethodData;
        public fixed uint Reserved158[10];
        public uint LineLengthIn;
        public uint LineCount;
        public uint OffsetOutUpper;
        public int OffsetOutUpperValue => (int)((OffsetOutUpper >> 0) & 0xFF);
        public uint OffsetOut;
        public uint PitchOut;
        public uint SetDstBlockSize;
        public SetDstBlockSizeWidth SetDstBlockSizeWidth => (SetDstBlockSizeWidth)((SetDstBlockSize >> 0) & 0xF);
        public SetDstBlockSizeHeight SetDstBlockSizeHeight => (SetDstBlockSizeHeight)((SetDstBlockSize >> 4) & 0xF);
        public SetDstBlockSizeDepth SetDstBlockSizeDepth => (SetDstBlockSizeDepth)((SetDstBlockSize >> 8) & 0xF);
        public uint SetDstWidth;
        public uint SetDstHeight;
        public uint SetDstDepth;
        public uint SetDstLayer;
        public uint SetDstOriginBytesX;
        public int SetDstOriginBytesXV => (int)((SetDstOriginBytesX >> 0) & 0xFFFFF);
        public uint SetDstOriginSamplesY;
        public int SetDstOriginSamplesYV => (int)((SetDstOriginSamplesY >> 0) & 0xFFFF);
        public uint LaunchDma;
        public LaunchDmaDstMemoryLayout LaunchDmaDstMemoryLayout => (LaunchDmaDstMemoryLayout)((LaunchDma >> 0) & 0x1);
        public LaunchDmaCompletionType LaunchDmaCompletionType => (LaunchDmaCompletionType)((LaunchDma >> 4) & 0x3);
        public LaunchDmaInterruptType LaunchDmaInterruptType => (LaunchDmaInterruptType)((LaunchDma >> 8) & 0x3);
        public LaunchDmaSemaphoreStructSize LaunchDmaSemaphoreStructSize => (LaunchDmaSemaphoreStructSize)((LaunchDma >> 12) & 0x1);
        public bool LaunchDmaReductionEnable => (LaunchDma & 0x2) != 0;
        public LaunchDmaReductionOp LaunchDmaReductionOp => (LaunchDmaReductionOp)((LaunchDma >> 13) & 0x7);
        public LaunchDmaReductionFormat LaunchDmaReductionFormat => (LaunchDmaReductionFormat)((LaunchDma >> 2) & 0x3);
        public bool LaunchDmaSysmembarDisable => (LaunchDma & 0x40) != 0;
        public uint LoadInlineData;
        public fixed uint Reserved1B8[22];
        public Boolean32 EarlyZForce;
        public fixed uint Reserved214[45];
        public uint SyncpointAction;
        public fixed uint Reserved2CC[44];
        public Boolean32 RasterizeEnable;
        public Array4<TfBufferState> TfBufferState;
        public fixed uint Reserved400[192];
        public Array4<TfState> TfState;
        public fixed uint Reserved740[1];
        public Boolean32 TfEnable;
        public fixed uint Reserved748[46];
        public Array8<RtColorState> RtColorState;
        public Array16<ViewportTransform> ViewportTransform;
        public Array16<ViewportExtents> ViewportExtents;
        public fixed uint ReservedD00[29];
        public VertexBufferDrawState VertexBufferDrawState;
        public uint DepthMode;
        public ClearColors ClearColors;
        public float ClearDepthValue;
        public fixed uint ReservedD94[3];
        public uint ClearStencilValue;
        public fixed uint ReservedDA4[7];
        public DepthBiasState DepthBiasState;
        public fixed uint ReservedDCC[5];
        public uint TextureBarrier;
        public fixed uint ReservedDE4[7];
        public Array16<ScissorState> ScissorState;
        public fixed uint ReservedF00[21];
        public StencilBackMasks StencilBackMasks;
        public fixed uint ReservedF60[5];
        public uint InvalidateTextures;
        public fixed uint ReservedF78[1];
        public uint TextureBarrierTiled;
        public fixed uint ReservedF80[4];
        public Boolean32 RtColorMaskShared;
        public fixed uint ReservedF94[19];
        public RtDepthStencilState RtDepthStencilState;
        public ScreenScissorState ScreenScissorState;
        public fixed uint ReservedFFC[89];
        public Array16<VertexAttribState> VertexAttribState;
        public fixed uint Reserved11A0[31];
        public RtControl RtControl;
        public fixed uint Reserved1220[2];
        public Size3D RtDepthStencilSize;
        public SamplerIndex SamplerIndex;
        public fixed uint Reserved1238[37];
        public Boolean32 DepthTestEnable;
        public fixed uint Reserved12D0[5];
        public Boolean32 BlendIndependent;
        public Boolean32 DepthWriteEnable;
        public Boolean32 AlphaTestEnable;
        public fixed uint Reserved12F0[5];
        public uint VbElementU8;
        public uint Reserved1308;
        public CompareOp DepthTestFunc;
        public float AlphaTestRef;
        public CompareOp AlphaTestFunc;
        public uint Reserved1318;
        public ColorF BlendConstant;
        public fixed uint Reserved132C[4];
        public BlendStateCommon BlendStateCommon;
        public Boolean32 BlendEnableCommon;
        public Array8<Boolean32> BlendEnable;
        public StencilTestState StencilTestState;
        public fixed uint Reserved13A0[3];
        public YControl YControl;
        public float LineWidthSmooth;
        public float LineWidthAliased;
        public fixed uint Reserved13B8[31];
        public uint FirstVertex;
        public uint FirstInstance;
        public fixed uint Reserved143C[53];
        public uint ClipDistanceEnable;
        public uint Reserved1514;
        public float PointSize;
        public uint Reserved151C;
        public Boolean32 PointSpriteEnable;
        public fixed uint Reserved1524[3];
        public uint ResetCounter;
        public uint Reserved1534;
        public Boolean32 RtDepthStencilEnable;
        public fixed uint Reserved153C[5];
        public ConditionState ConditionState;
        public PoolState SamplerPoolState;
        public uint Reserved1568;
        public float DepthBiasFactor;
        public Boolean32 LineSmoothEnable;
        public PoolState TexturePoolState;
        public fixed uint Reserved1580[5];
        public StencilBackTestState StencilBackTestState;
        public fixed uint Reserved15A8[5];
        public float DepthBiasUnits;
        public fixed uint Reserved15C0[4];
        public TextureMsaaMode RtMsaaMode;
        public fixed uint Reserved15D4[5];
        public uint VbElementU32;
        public uint Reserved15EC;
        public uint VbElementU16;
        public fixed uint Reserved15F4[4];
        public uint PointCoordReplace;
        public GpuVa ShaderBaseAddress;
        public uint Reserved1610;
        public uint DrawEnd;
        public uint DrawBegin;
        public fixed uint Reserved161C[10];
        public PrimitiveRestartState PrimitiveRestartState;
        public fixed uint Reserved164C[95];
        public IndexBufferState IndexBufferState;
        public uint IndexBufferCount;
        public uint DrawIndexedSmall;
        public uint DrawIndexedSmall2;
        public uint Reserved17EC;
        public uint DrawIndexedSmallIncInstance;
        public uint DrawIndexedSmallIncInstance2;
        public fixed uint Reserved17F8[33];
        public float DepthBiasClamp;
        public Array16<Boolean32> VertexBufferInstanced;
        public fixed uint Reserved18C0[20];
        public Boolean32 VertexProgramPointSize;
        public uint Reserved1914;
        public FaceState FaceState;
        public fixed uint Reserved1924[2];
        public uint ViewportTransformEnable;
        public fixed uint Reserved1930[3];
        public ViewVolumeClipControl ViewVolumeClipControl;
        public fixed uint Reserved1940[2];
        public Boolean32 PrimitiveTypeOverrideEnable;
        public fixed uint Reserved194C[9];
        public PrimitiveTypeOverride PrimitiveTypeOverride;
        public fixed uint Reserved1974[20];
        public LogicalOpState LogicOpState;
        public uint Reserved19CC;
        public uint Clear;
        public fixed uint Reserved19D4[11];
        public Array8<RtColorMask> RtColorMask;
        public fixed uint Reserved1A20[56];
        public GpuVa SemaphoreAddress;
        public int SemaphorePayload;
        public uint SemaphoreControl;
        public fixed uint Reserved1B10[60];
        public Array16<VertexBufferState> VertexBufferState;
        public fixed uint Reserved1D00[64];
        public Array8<BlendState> BlendState;
        public Array16<GpuVa> VertexBufferEndAddress;
        public fixed uint Reserved1F80[32];
        public Array6<ShaderState> ShaderState;
        public fixed uint Reserved2180[96];
        public uint SetFalcon00;
        public uint SetFalcon01;
        public uint SetFalcon02;
        public uint SetFalcon03;
        public uint SetFalcon04;
        public uint SetFalcon05;
        public uint SetFalcon06;
        public uint SetFalcon07;
        public uint SetFalcon08;
        public uint SetFalcon09;
        public uint SetFalcon10;
        public uint SetFalcon11;
        public uint SetFalcon12;
        public uint SetFalcon13;
        public uint SetFalcon14;
        public uint SetFalcon15;
        public uint SetFalcon16;
        public uint SetFalcon17;
        public uint SetFalcon18;
        public uint SetFalcon19;
        public uint SetFalcon20;
        public uint SetFalcon21;
        public uint SetFalcon22;
        public uint SetFalcon23;
        public uint SetFalcon24;
        public uint SetFalcon25;
        public uint SetFalcon26;
        public uint SetFalcon27;
        public uint SetFalcon28;
        public uint SetFalcon29;
        public uint SetFalcon30;
        public uint SetFalcon31;
        public UniformBufferState UniformBufferState;
        public Array16<uint> UniformBufferUpdateData;
        public fixed uint Reserved23D0[16];
        public uint UniformBufferBindVertex;
        public fixed uint Reserved2414[7];
        public uint UniformBufferBindTessControl;
        public fixed uint Reserved2434[7];
        public uint UniformBufferBindTessEvaluation;
        public fixed uint Reserved2454[7];
        public uint UniformBufferBindGeometry;
        public fixed uint Reserved2474[7];
        public uint UniformBufferBindFragment;
        public fixed uint Reserved2494[93];
        public uint TextureBufferIndex;
        public fixed uint Reserved260C[125];
        public Array4<Array32<uint>> TfVaryingLocations;
        public fixed uint Reserved2A00[640];
        public MmeShadowScratch SetMmeShadowScratch;
#pragma warning restore CS0649
    }
}
