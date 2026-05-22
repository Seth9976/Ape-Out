using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001C1 RID: 449
	public sealed class SysCommonMessage : ShortMessage
	{
		// Token: 0x060015C3 RID: 5571 RVA: 0x000636C4 File Offset: 0x000618C4
		// Note: this type is marked as 'beforefieldinit'.
		static SysCommonMessage()
		{
			Il2CppClassPointerStore<SysCommonMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "SysCommonMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SysCommonMessage>.NativeClassPtr);
			SysCommonMessage.NativeMethodInfoPtr__ctor_Public_Void_SysCommonType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysCommonMessage>.NativeClassPtr, 100666388);
			SysCommonMessage.NativeMethodInfoPtr__ctor_Public_Void_SysCommonType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysCommonMessage>.NativeClassPtr, 100666389);
			SysCommonMessage.NativeMethodInfoPtr__ctor_Public_Void_SysCommonType_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysCommonMessage>.NativeClassPtr, 100666390);
			SysCommonMessage.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysCommonMessage>.NativeClassPtr, 100666391);
			SysCommonMessage.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysCommonMessage>.NativeClassPtr, 100666392);
			SysCommonMessage.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysCommonMessage>.NativeClassPtr, 100666393);
			SysCommonMessage.NativeMethodInfoPtr_get_SysCommonType_Public_get_SysCommonType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysCommonMessage>.NativeClassPtr, 100666394);
			SysCommonMessage.NativeMethodInfoPtr_get_Data1_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysCommonMessage>.NativeClassPtr, 100666395);
			SysCommonMessage.NativeMethodInfoPtr_get_Data2_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysCommonMessage>.NativeClassPtr, 100666396);
			SysCommonMessage.NativeMethodInfoPtr_get_MessageType_Public_Virtual_get_MessageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysCommonMessage>.NativeClassPtr, 100666397);
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x000637BC File Offset: 0x000619BC
		[CallerCount(0)]
		public unsafe SysCommonMessage(SysCommonType type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SysCommonMessage>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysCommonMessage.NativeMethodInfoPtr__ctor_Public_Void_SysCommonType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x00063804 File Offset: 0x00061A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16890, XrefRangeEnd = 16891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SysCommonMessage(SysCommonType type, int data1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SysCommonMessage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysCommonMessage.NativeMethodInfoPtr__ctor_Public_Void_SysCommonType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x0006385C File Offset: 0x00061A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16891, XrefRangeEnd = 16893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SysCommonMessage(SysCommonType type, int data1, int data2)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SysCommonMessage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysCommonMessage.NativeMethodInfoPtr__ctor_Public_Void_SysCommonType_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x000638C0 File Offset: 0x00061AC0
		[CallerCount(0)]
		public unsafe SysCommonMessage(int message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SysCommonMessage>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref message;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysCommonMessage.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x00063908 File Offset: 0x00061B08
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysCommonMessage.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x00063944 File Offset: 0x00061B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16893, XrefRangeEnd = 16895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysCommonMessage.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x060015CA RID: 5578 RVA: 0x00063994 File Offset: 0x00061B94
		public unsafe SysCommonType SysCommonType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysCommonMessage.NativeMethodInfoPtr_get_SysCommonType_Public_get_SysCommonType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x060015CB RID: 5579 RVA: 0x000639D0 File Offset: 0x00061BD0
		public unsafe int Data1
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysCommonMessage.NativeMethodInfoPtr_get_Data1_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x060015CC RID: 5580 RVA: 0x00063A0C File Offset: 0x00061C0C
		public unsafe int Data2
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysCommonMessage.NativeMethodInfoPtr_get_Data2_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x060015CD RID: 5581 RVA: 0x00063A48 File Offset: 0x00061C48
		public unsafe override MessageType MessageType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysCommonMessage.NativeMethodInfoPtr_get_MessageType_Public_Virtual_get_MessageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x00008BF9 File Offset: 0x00006DF9
		public SysCommonMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001795 RID: 6037
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SysCommonType_0;

		// Token: 0x04001796 RID: 6038
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SysCommonType_Int32_0;

		// Token: 0x04001797 RID: 6039
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SysCommonType_Int32_Int32_0;

		// Token: 0x04001798 RID: 6040
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x04001799 RID: 6041
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400179A RID: 6042
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400179B RID: 6043
		private static readonly IntPtr NativeMethodInfoPtr_get_SysCommonType_Public_get_SysCommonType_0;

		// Token: 0x0400179C RID: 6044
		private static readonly IntPtr NativeMethodInfoPtr_get_Data1_Public_get_Int32_0;

		// Token: 0x0400179D RID: 6045
		private static readonly IntPtr NativeMethodInfoPtr_get_Data2_Public_get_Int32_0;

		// Token: 0x0400179E RID: 6046
		private static readonly IntPtr NativeMethodInfoPtr_get_MessageType_Public_Virtual_get_MessageType_0;
	}
}
