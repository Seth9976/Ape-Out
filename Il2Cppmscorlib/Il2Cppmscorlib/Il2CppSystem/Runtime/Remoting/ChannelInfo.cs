using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x0200038B RID: 907
	[Serializable]
	public class ChannelInfo : Object
	{
		// Token: 0x06003C19 RID: 15385 RVA: 0x0011DF6C File Offset: 0x0011C16C
		// Note: this type is marked as 'beforefieldinit'.
		static ChannelInfo()
		{
			Il2CppClassPointerStore<ChannelInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "ChannelInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChannelInfo>.NativeClassPtr);
			ChannelInfo.NativeFieldInfoPtr_channelData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelInfo>.NativeClassPtr, "channelData");
			ChannelInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelInfo>.NativeClassPtr, 100672245);
			ChannelInfo.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelInfo>.NativeClassPtr, 100672246);
			ChannelInfo.NativeMethodInfoPtr_get_ChannelData_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelInfo>.NativeClassPtr, 100672247);
		}

		// Token: 0x06003C1A RID: 15386 RVA: 0x0011DFEC File Offset: 0x0011C1EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219039, XrefRangeEnd = 219043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChannelInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChannelInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C1B RID: 15387 RVA: 0x0011E028 File Offset: 0x0011C228
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 219048, RefRangeEnd = 219050, XrefRangeStart = 219043, XrefRangeEnd = 219048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChannelInfo(Object remoteChannelData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChannelInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(remoteChannelData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelInfo.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x06003C1C RID: 15388 RVA: 0x0011E074 File Offset: 0x0011C274
		public unsafe virtual Il2CppReferenceArray<Object> ChannelData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelInfo.NativeMethodInfoPtr_get_ChannelData_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06003C1D RID: 15389 RVA: 0x0001666E File Offset: 0x0001486E
		public ChannelInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x06003C1E RID: 15390 RVA: 0x0011E0B4 File Offset: 0x0011C2B4
		// (set) Token: 0x06003C1F RID: 15391 RVA: 0x00016677 File Offset: 0x00014877
		public unsafe Il2CppReferenceArray<Object> channelData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelInfo.NativeFieldInfoPtr_channelData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelInfo.NativeFieldInfoPtr_channelData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003205 RID: 12805
		private static readonly IntPtr NativeFieldInfoPtr_channelData;

		// Token: 0x04003206 RID: 12806
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003207 RID: 12807
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

		// Token: 0x04003208 RID: 12808
		private static readonly IntPtr NativeMethodInfoPtr_get_ChannelData_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0;
	}
}
