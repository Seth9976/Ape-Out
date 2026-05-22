using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001A8 RID: 424
	public class MetaMessageEventArgs : EventArgs
	{
		// Token: 0x06001439 RID: 5177 RVA: 0x0005DB90 File Offset: 0x0005BD90
		// Note: this type is marked as 'beforefieldinit'.
		static MetaMessageEventArgs()
		{
			Il2CppClassPointerStore<MetaMessageEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "MetaMessageEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MetaMessageEventArgs>.NativeClassPtr);
			MetaMessageEventArgs.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaMessageEventArgs>.NativeClassPtr, "message");
			MetaMessageEventArgs.NativeMethodInfoPtr__ctor_Public_Void_MetaMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaMessageEventArgs>.NativeClassPtr, 100666176);
			MetaMessageEventArgs.NativeMethodInfoPtr_get_Message_Public_get_MetaMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaMessageEventArgs>.NativeClassPtr, 100666177);
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x0005DBFC File Offset: 0x0005BDFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16161, XrefRangeEnd = 16164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MetaMessageEventArgs(MetaMessage message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MetaMessageEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaMessageEventArgs.NativeMethodInfoPtr__ctor_Public_Void_MetaMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x0600143B RID: 5179 RVA: 0x0005DC48 File Offset: 0x0005BE48
		public unsafe MetaMessage Message
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaMessageEventArgs.NativeMethodInfoPtr_get_Message_Public_get_MetaMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MetaMessage>(intPtr3) : null;
			}
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x00008481 File Offset: 0x00006681
		public MetaMessageEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x0600143D RID: 5181 RVA: 0x0005DC88 File Offset: 0x0005BE88
		// (set) Token: 0x0600143E RID: 5182 RVA: 0x0000848A File Offset: 0x0000668A
		public unsafe MetaMessage message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaMessageEventArgs.NativeFieldInfoPtr_message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MetaMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaMessageEventArgs.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001661 RID: 5729
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x04001662 RID: 5730
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MetaMessage_0;

		// Token: 0x04001663 RID: 5731
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_get_MetaMessage_0;
	}
}
