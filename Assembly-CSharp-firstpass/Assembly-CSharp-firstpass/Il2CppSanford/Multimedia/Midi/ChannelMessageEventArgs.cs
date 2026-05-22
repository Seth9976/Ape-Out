using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001A5 RID: 421
	public class ChannelMessageEventArgs : EventArgs
	{
		// Token: 0x06001427 RID: 5159 RVA: 0x0005D828 File Offset: 0x0005BA28
		// Note: this type is marked as 'beforefieldinit'.
		static ChannelMessageEventArgs()
		{
			Il2CppClassPointerStore<ChannelMessageEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "ChannelMessageEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChannelMessageEventArgs>.NativeClassPtr);
			ChannelMessageEventArgs.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelMessageEventArgs>.NativeClassPtr, "message");
			ChannelMessageEventArgs.NativeMethodInfoPtr__ctor_Public_Void_ChannelMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMessageEventArgs>.NativeClassPtr, 100666170);
			ChannelMessageEventArgs.NativeMethodInfoPtr_get_Message_Public_get_ChannelMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMessageEventArgs>.NativeClassPtr, 100666171);
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x0005D894 File Offset: 0x0005BA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16152, XrefRangeEnd = 16155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChannelMessageEventArgs(ChannelMessage message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChannelMessageEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMessageEventArgs.NativeMethodInfoPtr__ctor_Public_Void_ChannelMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06001429 RID: 5161 RVA: 0x0005D8E0 File Offset: 0x0005BAE0
		public unsafe ChannelMessage Message
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMessageEventArgs.NativeMethodInfoPtr_get_Message_Public_get_ChannelMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChannelMessage>(intPtr3) : null;
			}
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x0000840D File Offset: 0x0000660D
		public ChannelMessageEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x0600142B RID: 5163 RVA: 0x0005D920 File Offset: 0x0005BB20
		// (set) Token: 0x0600142C RID: 5164 RVA: 0x00008416 File Offset: 0x00006616
		public unsafe ChannelMessage message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelMessageEventArgs.NativeFieldInfoPtr_message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChannelMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelMessageEventArgs.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001658 RID: 5720
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x04001659 RID: 5721
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ChannelMessage_0;

		// Token: 0x0400165A RID: 5722
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_get_ChannelMessage_0;
	}
}
