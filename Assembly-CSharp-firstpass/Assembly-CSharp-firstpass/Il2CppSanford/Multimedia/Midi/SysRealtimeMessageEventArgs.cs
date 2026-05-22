using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001AC RID: 428
	public class SysRealtimeMessageEventArgs : EventArgs
	{
		// Token: 0x06001456 RID: 5206 RVA: 0x0005E21C File Offset: 0x0005C41C
		// Note: this type is marked as 'beforefieldinit'.
		static SysRealtimeMessageEventArgs()
		{
			Il2CppClassPointerStore<SysRealtimeMessageEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "SysRealtimeMessageEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SysRealtimeMessageEventArgs>.NativeClassPtr);
			SysRealtimeMessageEventArgs.NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SysRealtimeMessageEventArgs>.NativeClassPtr, "Start");
			SysRealtimeMessageEventArgs.NativeFieldInfoPtr_Continue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SysRealtimeMessageEventArgs>.NativeClassPtr, "Continue");
			SysRealtimeMessageEventArgs.NativeFieldInfoPtr_Stop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SysRealtimeMessageEventArgs>.NativeClassPtr, "Stop");
			SysRealtimeMessageEventArgs.NativeFieldInfoPtr_Clock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SysRealtimeMessageEventArgs>.NativeClassPtr, "Clock");
			SysRealtimeMessageEventArgs.NativeFieldInfoPtr_Tick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SysRealtimeMessageEventArgs>.NativeClassPtr, "Tick");
			SysRealtimeMessageEventArgs.NativeFieldInfoPtr_ActiveSense = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SysRealtimeMessageEventArgs>.NativeClassPtr, "ActiveSense");
			SysRealtimeMessageEventArgs.NativeFieldInfoPtr_Reset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SysRealtimeMessageEventArgs>.NativeClassPtr, "Reset");
			SysRealtimeMessageEventArgs.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SysRealtimeMessageEventArgs>.NativeClassPtr, "message");
			SysRealtimeMessageEventArgs.NativeMethodInfoPtr__ctor_Private_Void_SysRealtimeMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysRealtimeMessageEventArgs>.NativeClassPtr, 100666189);
			SysRealtimeMessageEventArgs.NativeMethodInfoPtr_get_Message_Public_get_SysRealtimeMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysRealtimeMessageEventArgs>.NativeClassPtr, 100666190);
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x0005E314 File Offset: 0x0005C514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16202, XrefRangeEnd = 16205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SysRealtimeMessageEventArgs(SysRealtimeMessage message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SysRealtimeMessageEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysRealtimeMessageEventArgs.NativeMethodInfoPtr__ctor_Private_Void_SysRealtimeMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06001458 RID: 5208 RVA: 0x0005E360 File Offset: 0x0005C560
		public unsafe SysRealtimeMessage Message
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysRealtimeMessageEventArgs.NativeMethodInfoPtr_get_Message_Public_get_SysRealtimeMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SysRealtimeMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x00008521 File Offset: 0x00006721
		public SysRealtimeMessageEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x0600145A RID: 5210 RVA: 0x0005E3A0 File Offset: 0x0005C5A0
		// (set) Token: 0x0600145B RID: 5211 RVA: 0x0000852A File Offset: 0x0000672A
		public unsafe static SysRealtimeMessageEventArgs Start
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SysRealtimeMessageEventArgs.NativeFieldInfoPtr_Start, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SysRealtimeMessageEventArgs>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SysRealtimeMessageEventArgs.NativeFieldInfoPtr_Start, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x0600145C RID: 5212 RVA: 0x0005E3C8 File Offset: 0x0005C5C8
		// (set) Token: 0x0600145D RID: 5213 RVA: 0x0000853C File Offset: 0x0000673C
		public unsafe static SysRealtimeMessageEventArgs Continue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SysRealtimeMessageEventArgs.NativeFieldInfoPtr_Continue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SysRealtimeMessageEventArgs>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SysRealtimeMessageEventArgs.NativeFieldInfoPtr_Continue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x0600145E RID: 5214 RVA: 0x0005E3F0 File Offset: 0x0005C5F0
		// (set) Token: 0x0600145F RID: 5215 RVA: 0x0000854E File Offset: 0x0000674E
		public unsafe static SysRealtimeMessageEventArgs Stop
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SysRealtimeMessageEventArgs.NativeFieldInfoPtr_Stop, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SysRealtimeMessageEventArgs>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SysRealtimeMessageEventArgs.NativeFieldInfoPtr_Stop, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06001460 RID: 5216 RVA: 0x0005E418 File Offset: 0x0005C618
		// (set) Token: 0x06001461 RID: 5217 RVA: 0x00008560 File Offset: 0x00006760
		public unsafe static SysRealtimeMessageEventArgs Clock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SysRealtimeMessageEventArgs.NativeFieldInfoPtr_Clock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SysRealtimeMessageEventArgs>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SysRealtimeMessageEventArgs.NativeFieldInfoPtr_Clock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06001462 RID: 5218 RVA: 0x0005E440 File Offset: 0x0005C640
		// (set) Token: 0x06001463 RID: 5219 RVA: 0x00008572 File Offset: 0x00006772
		public unsafe static SysRealtimeMessageEventArgs Tick
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SysRealtimeMessageEventArgs.NativeFieldInfoPtr_Tick, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SysRealtimeMessageEventArgs>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SysRealtimeMessageEventArgs.NativeFieldInfoPtr_Tick, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06001464 RID: 5220 RVA: 0x0005E468 File Offset: 0x0005C668
		// (set) Token: 0x06001465 RID: 5221 RVA: 0x00008584 File Offset: 0x00006784
		public unsafe static SysRealtimeMessageEventArgs ActiveSense
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SysRealtimeMessageEventArgs.NativeFieldInfoPtr_ActiveSense, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SysRealtimeMessageEventArgs>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SysRealtimeMessageEventArgs.NativeFieldInfoPtr_ActiveSense, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06001466 RID: 5222 RVA: 0x0005E490 File Offset: 0x0005C690
		// (set) Token: 0x06001467 RID: 5223 RVA: 0x00008596 File Offset: 0x00006796
		public unsafe static SysRealtimeMessageEventArgs Reset
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SysRealtimeMessageEventArgs.NativeFieldInfoPtr_Reset, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SysRealtimeMessageEventArgs>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SysRealtimeMessageEventArgs.NativeFieldInfoPtr_Reset, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06001468 RID: 5224 RVA: 0x0005E4B8 File Offset: 0x0005C6B8
		// (set) Token: 0x06001469 RID: 5225 RVA: 0x000085A8 File Offset: 0x000067A8
		public unsafe SysRealtimeMessage message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SysRealtimeMessageEventArgs.NativeFieldInfoPtr_message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SysRealtimeMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SysRealtimeMessageEventArgs.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001672 RID: 5746
		private static readonly IntPtr NativeFieldInfoPtr_Start;

		// Token: 0x04001673 RID: 5747
		private static readonly IntPtr NativeFieldInfoPtr_Continue;

		// Token: 0x04001674 RID: 5748
		private static readonly IntPtr NativeFieldInfoPtr_Stop;

		// Token: 0x04001675 RID: 5749
		private static readonly IntPtr NativeFieldInfoPtr_Clock;

		// Token: 0x04001676 RID: 5750
		private static readonly IntPtr NativeFieldInfoPtr_Tick;

		// Token: 0x04001677 RID: 5751
		private static readonly IntPtr NativeFieldInfoPtr_ActiveSense;

		// Token: 0x04001678 RID: 5752
		private static readonly IntPtr NativeFieldInfoPtr_Reset;

		// Token: 0x04001679 RID: 5753
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x0400167A RID: 5754
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SysRealtimeMessage_0;

		// Token: 0x0400167B RID: 5755
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_get_SysRealtimeMessage_0;
	}
}
