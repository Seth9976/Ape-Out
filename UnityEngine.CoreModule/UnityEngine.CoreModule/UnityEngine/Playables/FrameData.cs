using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x0200017B RID: 379
	[StructLayout(2)]
	public struct FrameData
	{
		// Token: 0x06001D1C RID: 7452 RVA: 0x0006ADF8 File Offset: 0x00068FF8
		// Note: this type is marked as 'beforefieldinit'.
		static FrameData()
		{
			Il2CppClassPointerStore<FrameData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "FrameData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameData>.NativeClassPtr);
			FrameData.NativeFieldInfoPtr_m_FrameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_FrameID");
			FrameData.NativeFieldInfoPtr_m_DeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_DeltaTime");
			FrameData.NativeFieldInfoPtr_m_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_Weight");
			FrameData.NativeFieldInfoPtr_m_EffectiveWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_EffectiveWeight");
			FrameData.NativeFieldInfoPtr_m_EffectiveParentDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_EffectiveParentDelay");
			FrameData.NativeFieldInfoPtr_m_EffectiveParentSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_EffectiveParentSpeed");
			FrameData.NativeFieldInfoPtr_m_EffectiveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_EffectiveSpeed");
			FrameData.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_Flags");
			FrameData.NativeFieldInfoPtr_m_Output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_Output");
			FrameData.NativeMethodInfoPtr_HasFlags_Private_Boolean_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100665891);
			FrameData.NativeMethodInfoPtr_get_deltaTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100665892);
			FrameData.NativeMethodInfoPtr_get_effectiveSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100665893);
			FrameData.NativeMethodInfoPtr_get_evaluationType_Public_get_EvaluationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100665894);
			FrameData.NativeMethodInfoPtr_get_seekOccurred_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100665895);
			FrameData.NativeMethodInfoPtr_get_timeLooped_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100665896);
			FrameData.NativeMethodInfoPtr_get_timeHeld_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100665897);
			FrameData.NativeMethodInfoPtr_get_output_Public_get_PlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100665898);
			FrameData.NativeMethodInfoPtr_get_effectivePlayState_Public_get_PlayState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100665899);
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x0006AF90 File Offset: 0x00069190
		[CallerCount(0)]
		public unsafe bool HasFlags(FrameData.Flags flag)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flag;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameData.NativeMethodInfoPtr_HasFlags_Private_Boolean_Flags_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001D1E RID: 7454 RVA: 0x0006AFD0 File Offset: 0x000691D0
		public unsafe float deltaTime
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameData.NativeMethodInfoPtr_get_deltaTime_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001D1F RID: 7455 RVA: 0x0006B000 File Offset: 0x00069200
		public unsafe float effectiveSpeed
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 500679, RefRangeEnd = 500689, XrefRangeStart = 500679, XrefRangeEnd = 500689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameData.NativeMethodInfoPtr_get_effectiveSpeed_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001D20 RID: 7456 RVA: 0x0006B030 File Offset: 0x00069230
		public unsafe FrameData.EvaluationType evaluationType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameData.NativeMethodInfoPtr_get_evaluationType_Public_get_EvaluationType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001D21 RID: 7457 RVA: 0x0006B060 File Offset: 0x00069260
		public unsafe bool seekOccurred
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameData.NativeMethodInfoPtr_get_seekOccurred_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001D22 RID: 7458 RVA: 0x0006B090 File Offset: 0x00069290
		public unsafe bool timeLooped
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameData.NativeMethodInfoPtr_get_timeLooped_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001D23 RID: 7459 RVA: 0x0006B0C0 File Offset: 0x000692C0
		public unsafe bool timeHeld
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameData.NativeMethodInfoPtr_get_timeHeld_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001D24 RID: 7460 RVA: 0x0006B0F0 File Offset: 0x000692F0
		public unsafe PlayableOutput output
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameData.NativeMethodInfoPtr_get_output_Public_get_PlayableOutput_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001D25 RID: 7461 RVA: 0x0006B120 File Offset: 0x00069320
		public unsafe PlayState effectivePlayState
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameData.NativeMethodInfoPtr_get_effectivePlayState_Public_get_PlayState_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x0000F9A4 File Offset: 0x0000DBA4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FrameData>.NativeClassPtr, ref this));
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001D27 RID: 7463 RVA: 0x0006B150 File Offset: 0x00069350
		public ulong frameId
		{
			get
			{
				return this.m_FrameID;
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001D28 RID: 7464 RVA: 0x0006B168 File Offset: 0x00069368
		public float weight
		{
			get
			{
				return this.m_Weight;
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06001D29 RID: 7465 RVA: 0x0006B180 File Offset: 0x00069380
		public float effectiveWeight
		{
			get
			{
				return this.m_EffectiveWeight;
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001D2A RID: 7466 RVA: 0x0006B198 File Offset: 0x00069398
		public double effectiveParentDelay
		{
			get
			{
				return this.m_EffectiveParentDelay;
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06001D2B RID: 7467 RVA: 0x0006B1B0 File Offset: 0x000693B0
		public float effectiveParentSpeed
		{
			get
			{
				return this.m_EffectiveParentSpeed;
			}
		}

		// Token: 0x0400165A RID: 5722
		private static readonly IntPtr NativeFieldInfoPtr_m_FrameID;

		// Token: 0x0400165B RID: 5723
		private static readonly IntPtr NativeFieldInfoPtr_m_DeltaTime;

		// Token: 0x0400165C RID: 5724
		private static readonly IntPtr NativeFieldInfoPtr_m_Weight;

		// Token: 0x0400165D RID: 5725
		private static readonly IntPtr NativeFieldInfoPtr_m_EffectiveWeight;

		// Token: 0x0400165E RID: 5726
		private static readonly IntPtr NativeFieldInfoPtr_m_EffectiveParentDelay;

		// Token: 0x0400165F RID: 5727
		private static readonly IntPtr NativeFieldInfoPtr_m_EffectiveParentSpeed;

		// Token: 0x04001660 RID: 5728
		private static readonly IntPtr NativeFieldInfoPtr_m_EffectiveSpeed;

		// Token: 0x04001661 RID: 5729
		private static readonly IntPtr NativeFieldInfoPtr_m_Flags;

		// Token: 0x04001662 RID: 5730
		private static readonly IntPtr NativeFieldInfoPtr_m_Output;

		// Token: 0x04001663 RID: 5731
		private static readonly IntPtr NativeMethodInfoPtr_HasFlags_Private_Boolean_Flags_0;

		// Token: 0x04001664 RID: 5732
		private static readonly IntPtr NativeMethodInfoPtr_get_deltaTime_Public_get_Single_0;

		// Token: 0x04001665 RID: 5733
		private static readonly IntPtr NativeMethodInfoPtr_get_effectiveSpeed_Public_get_Single_0;

		// Token: 0x04001666 RID: 5734
		private static readonly IntPtr NativeMethodInfoPtr_get_evaluationType_Public_get_EvaluationType_0;

		// Token: 0x04001667 RID: 5735
		private static readonly IntPtr NativeMethodInfoPtr_get_seekOccurred_Public_get_Boolean_0;

		// Token: 0x04001668 RID: 5736
		private static readonly IntPtr NativeMethodInfoPtr_get_timeLooped_Public_get_Boolean_0;

		// Token: 0x04001669 RID: 5737
		private static readonly IntPtr NativeMethodInfoPtr_get_timeHeld_Public_get_Boolean_0;

		// Token: 0x0400166A RID: 5738
		private static readonly IntPtr NativeMethodInfoPtr_get_output_Public_get_PlayableOutput_0;

		// Token: 0x0400166B RID: 5739
		private static readonly IntPtr NativeMethodInfoPtr_get_effectivePlayState_Public_get_PlayState_0;

		// Token: 0x0400166C RID: 5740
		[FieldOffset(0)]
		public ulong m_FrameID;

		// Token: 0x0400166D RID: 5741
		[FieldOffset(8)]
		public double m_DeltaTime;

		// Token: 0x0400166E RID: 5742
		[FieldOffset(16)]
		public float m_Weight;

		// Token: 0x0400166F RID: 5743
		[FieldOffset(20)]
		public float m_EffectiveWeight;

		// Token: 0x04001670 RID: 5744
		[FieldOffset(24)]
		public double m_EffectiveParentDelay;

		// Token: 0x04001671 RID: 5745
		[FieldOffset(32)]
		public float m_EffectiveParentSpeed;

		// Token: 0x04001672 RID: 5746
		[FieldOffset(36)]
		public float m_EffectiveSpeed;

		// Token: 0x04001673 RID: 5747
		[FieldOffset(40)]
		public FrameData.Flags m_Flags;

		// Token: 0x04001674 RID: 5748
		[FieldOffset(48)]
		public PlayableOutput m_Output;

		// Token: 0x020009F3 RID: 2547
		[OriginalName("UnityEngine.CoreModule.dll", "", "Flags")]
		[Flags]
		public enum Flags
		{
			// Token: 0x04001FCF RID: 8143
			Evaluate = 1,
			// Token: 0x04001FD0 RID: 8144
			SeekOccured = 2,
			// Token: 0x04001FD1 RID: 8145
			Loop = 4,
			// Token: 0x04001FD2 RID: 8146
			Hold = 8,
			// Token: 0x04001FD3 RID: 8147
			EffectivePlayStateDelayed = 16,
			// Token: 0x04001FD4 RID: 8148
			EffectivePlayStatePlaying = 32
		}

		// Token: 0x020009F4 RID: 2548
		[OriginalName("UnityEngine.CoreModule.dll", "", "EvaluationType")]
		public enum EvaluationType
		{
			// Token: 0x04001FD6 RID: 8150
			Evaluate,
			// Token: 0x04001FD7 RID: 8151
			Playback
		}
	}
}
