using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001AB RID: 427
	public class SysExMessageEventArgs : EventArgs
	{
		// Token: 0x06001450 RID: 5200 RVA: 0x0005E0F4 File Offset: 0x0005C2F4
		// Note: this type is marked as 'beforefieldinit'.
		static SysExMessageEventArgs()
		{
			Il2CppClassPointerStore<SysExMessageEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "SysExMessageEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SysExMessageEventArgs>.NativeClassPtr);
			SysExMessageEventArgs.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SysExMessageEventArgs>.NativeClassPtr, "message");
			SysExMessageEventArgs.NativeMethodInfoPtr__ctor_Public_Void_SysExMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysExMessageEventArgs>.NativeClassPtr, 100666187);
			SysExMessageEventArgs.NativeMethodInfoPtr_get_Message_Public_get_SysExMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysExMessageEventArgs>.NativeClassPtr, 100666188);
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x0005E160 File Offset: 0x0005C360
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 16201, RefRangeEnd = 16202, XrefRangeStart = 16198, XrefRangeEnd = 16201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SysExMessageEventArgs(SysExMessage message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SysExMessageEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysExMessageEventArgs.NativeMethodInfoPtr__ctor_Public_Void_SysExMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06001452 RID: 5202 RVA: 0x0005E1AC File Offset: 0x0005C3AC
		public unsafe SysExMessage Message
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysExMessageEventArgs.NativeMethodInfoPtr_get_Message_Public_get_SysExMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SysExMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x000084F9 File Offset: 0x000066F9
		public SysExMessageEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06001454 RID: 5204 RVA: 0x0005E1EC File Offset: 0x0005C3EC
		// (set) Token: 0x06001455 RID: 5205 RVA: 0x00008502 File Offset: 0x00006702
		public unsafe SysExMessage message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SysExMessageEventArgs.NativeFieldInfoPtr_message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SysExMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SysExMessageEventArgs.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400166F RID: 5743
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x04001670 RID: 5744
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SysExMessage_0;

		// Token: 0x04001671 RID: 5745
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_get_SysExMessage_0;
	}
}
