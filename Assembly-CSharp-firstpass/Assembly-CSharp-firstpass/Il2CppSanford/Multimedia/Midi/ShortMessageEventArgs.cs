using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001A9 RID: 425
	public class ShortMessageEventArgs : EventArgs
	{
		// Token: 0x0600143F RID: 5183 RVA: 0x0005DCB8 File Offset: 0x0005BEB8
		// Note: this type is marked as 'beforefieldinit'.
		static ShortMessageEventArgs()
		{
			Il2CppClassPointerStore<ShortMessageEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "ShortMessageEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortMessageEventArgs>.NativeClassPtr);
			ShortMessageEventArgs.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortMessageEventArgs>.NativeClassPtr, "message");
			ShortMessageEventArgs.NativeMethodInfoPtr__ctor_Public_Void_ShortMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortMessageEventArgs>.NativeClassPtr, 100666178);
			ShortMessageEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortMessageEventArgs>.NativeClassPtr, 100666179);
			ShortMessageEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortMessageEventArgs>.NativeClassPtr, 100666180);
			ShortMessageEventArgs.NativeMethodInfoPtr_get_Message_Public_get_ShortMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortMessageEventArgs>.NativeClassPtr, 100666181);
			ShortMessageEventArgs.NativeMethodInfoPtr_FromChannelMessage_Public_Static_ShortMessageEventArgs_ChannelMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortMessageEventArgs>.NativeClassPtr, 100666182);
			ShortMessageEventArgs.NativeMethodInfoPtr_FromSysCommonMessage_Public_Static_ShortMessageEventArgs_SysCommonMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortMessageEventArgs>.NativeClassPtr, 100666183);
			ShortMessageEventArgs.NativeMethodInfoPtr_FromSysRealtimeMessage_Public_Static_ShortMessageEventArgs_SysRealtimeMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortMessageEventArgs>.NativeClassPtr, 100666184);
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x0005DD88 File Offset: 0x0005BF88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 16167, RefRangeEnd = 16170, XrefRangeStart = 16164, XrefRangeEnd = 16167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShortMessageEventArgs(ShortMessage message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortMessageEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortMessageEventArgs.NativeMethodInfoPtr__ctor_Public_Void_ShortMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x0005DDD4 File Offset: 0x0005BFD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16170, XrefRangeEnd = 16176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShortMessageEventArgs(int message, int timestamp = 0)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortMessageEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref message;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timestamp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortMessageEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x0005DE2C File Offset: 0x0005C02C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16176, XrefRangeEnd = 16183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShortMessageEventArgs(byte status, byte data1, byte data2)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortMessageEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref status;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortMessageEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06001443 RID: 5187 RVA: 0x0005DE90 File Offset: 0x0005C090
		public unsafe ShortMessage Message
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortMessageEventArgs.NativeMethodInfoPtr_get_Message_Public_get_ShortMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ShortMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x0005DED0 File Offset: 0x0005C0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16183, XrefRangeEnd = 16187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ShortMessageEventArgs FromChannelMessage(ChannelMessageEventArgs arg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortMessageEventArgs.NativeMethodInfoPtr_FromChannelMessage_Public_Static_ShortMessageEventArgs_ChannelMessageEventArgs_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ShortMessageEventArgs>(intPtr3) : null;
			}
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x0005DF14 File Offset: 0x0005C114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16187, XrefRangeEnd = 16191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ShortMessageEventArgs FromSysCommonMessage(SysCommonMessageEventArgs arg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortMessageEventArgs.NativeMethodInfoPtr_FromSysCommonMessage_Public_Static_ShortMessageEventArgs_SysCommonMessageEventArgs_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ShortMessageEventArgs>(intPtr3) : null;
			}
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x0005DF58 File Offset: 0x0005C158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16191, XrefRangeEnd = 16195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ShortMessageEventArgs FromSysRealtimeMessage(SysRealtimeMessageEventArgs arg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortMessageEventArgs.NativeMethodInfoPtr_FromSysRealtimeMessage_Public_Static_ShortMessageEventArgs_SysRealtimeMessageEventArgs_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ShortMessageEventArgs>(intPtr3) : null;
			}
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x000084A9 File Offset: 0x000066A9
		public ShortMessageEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06001448 RID: 5192 RVA: 0x0005DF9C File Offset: 0x0005C19C
		// (set) Token: 0x06001449 RID: 5193 RVA: 0x000084B2 File Offset: 0x000066B2
		public unsafe ShortMessage message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortMessageEventArgs.NativeFieldInfoPtr_message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShortMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortMessageEventArgs.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001664 RID: 5732
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x04001665 RID: 5733
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ShortMessage_0;

		// Token: 0x04001666 RID: 5734
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04001667 RID: 5735
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_Byte_0;

		// Token: 0x04001668 RID: 5736
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_get_ShortMessage_0;

		// Token: 0x04001669 RID: 5737
		private static readonly IntPtr NativeMethodInfoPtr_FromChannelMessage_Public_Static_ShortMessageEventArgs_ChannelMessageEventArgs_0;

		// Token: 0x0400166A RID: 5738
		private static readonly IntPtr NativeMethodInfoPtr_FromSysCommonMessage_Public_Static_ShortMessageEventArgs_SysCommonMessageEventArgs_0;

		// Token: 0x0400166B RID: 5739
		private static readonly IntPtr NativeMethodInfoPtr_FromSysRealtimeMessage_Public_Static_ShortMessageEventArgs_SysRealtimeMessageEventArgs_0;
	}
}
