using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.InteropServices;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000099 RID: 153
	[Serializable]
	public class Win32Exception : ExternalException
	{
		// Token: 0x06000911 RID: 2321 RVA: 0x0003232C File Offset: 0x0003052C
		// Note: this type is marked as 'beforefieldinit'.
		static Win32Exception()
		{
			Il2CppClassPointerStore<Win32Exception>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "Win32Exception");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr);
			Win32Exception.NativeFieldInfoPtr_nativeErrorCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr, "nativeErrorCode");
			Win32Exception.NativeFieldInfoPtr_s_ErrorMessagesInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr, "s_ErrorMessagesInitialized");
			Win32Exception.NativeFieldInfoPtr_s_ErrorMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr, "s_ErrorMessage");
			Win32Exception.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr, 100664578);
			Win32Exception.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr, 100664579);
			Win32Exception.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr, 100664580);
			Win32Exception.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr, 100664581);
			Win32Exception.NativeMethodInfoPtr_get_NativeErrorCode_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr, 100664582);
			Win32Exception.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr, 100664583);
			Win32Exception.NativeMethodInfoPtr_GetErrorMessage_Internal_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr, 100664584);
			Win32Exception.NativeMethodInfoPtr_InitializeErrorMessages_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr, 100664585);
			Win32Exception.NativeMethodInfoPtr_InitializeErrorMessages1_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr, 100664586);
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x0003244C File Offset: 0x0003064C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372859, XrefRangeEnd = 372865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Win32Exception()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Exception.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x00032488 File Offset: 0x00030688
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 372870, RefRangeEnd = 372876, XrefRangeStart = 372865, XrefRangeEnd = 372870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Win32Exception(int error)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Exception.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x000324D0 File Offset: 0x000306D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372876, XrefRangeEnd = 372877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Win32Exception(int error, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Exception.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x0003252C File Offset: 0x0003072C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372877, XrefRangeEnd = 372884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Win32Exception(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Exception.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x00032590 File Offset: 0x00030790
		public unsafe int NativeErrorCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Exception.NativeMethodInfoPtr_get_NativeErrorCode_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x000325CC File Offset: 0x000307CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372884, XrefRangeEnd = 372888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Win32Exception.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00032630 File Offset: 0x00030830
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 372905, RefRangeEnd = 372906, XrefRangeStart = 372888, XrefRangeEnd = 372905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetErrorMessage(int error)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Exception.NativeMethodInfoPtr_GetErrorMessage_Internal_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00032668 File Offset: 0x00030868
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 372922, RefRangeEnd = 372923, XrefRangeStart = 372906, XrefRangeEnd = 372922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeErrorMessages()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Exception.NativeMethodInfoPtr_InitializeErrorMessages_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x00032690 File Offset: 0x00030890
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 373139, RefRangeEnd = 373140, XrefRangeStart = 372923, XrefRangeEnd = 373139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeErrorMessages1()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Exception.NativeMethodInfoPtr_InitializeErrorMessages1_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x00005AA0 File Offset: 0x00003CA0
		public Win32Exception(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x000326B8 File Offset: 0x000308B8
		// (set) Token: 0x0600091D RID: 2333 RVA: 0x00005AA9 File Offset: 0x00003CA9
		public unsafe int nativeErrorCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32Exception.NativeFieldInfoPtr_nativeErrorCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32Exception.NativeFieldInfoPtr_nativeErrorCode)) = value;
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x000326E0 File Offset: 0x000308E0
		// (set) Token: 0x0600091F RID: 2335 RVA: 0x00005AC4 File Offset: 0x00003CC4
		public unsafe static bool s_ErrorMessagesInitialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Win32Exception.NativeFieldInfoPtr_s_ErrorMessagesInitialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Win32Exception.NativeFieldInfoPtr_s_ErrorMessagesInitialized, (void*)(&value));
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000920 RID: 2336 RVA: 0x000326FC File Offset: 0x000308FC
		// (set) Token: 0x06000921 RID: 2337 RVA: 0x00005AD2 File Offset: 0x00003CD2
		public unsafe static Dictionary<int, string> s_ErrorMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Win32Exception.NativeFieldInfoPtr_s_ErrorMessage, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Win32Exception.NativeFieldInfoPtr_s_ErrorMessage, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400068C RID: 1676
		private static readonly IntPtr NativeFieldInfoPtr_nativeErrorCode;

		// Token: 0x0400068D RID: 1677
		private static readonly IntPtr NativeFieldInfoPtr_s_ErrorMessagesInitialized;

		// Token: 0x0400068E RID: 1678
		private static readonly IntPtr NativeFieldInfoPtr_s_ErrorMessage;

		// Token: 0x0400068F RID: 1679
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000690 RID: 1680
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000691 RID: 1681
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0;

		// Token: 0x04000692 RID: 1682
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeMethodInfoPtr_get_NativeErrorCode_Public_get_Int32_0;

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeMethodInfoPtr_GetErrorMessage_Internal_Static_String_Int32_0;

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeMethodInfoPtr_InitializeErrorMessages_Private_Static_Void_0;

		// Token: 0x04000697 RID: 1687
		private static readonly IntPtr NativeMethodInfoPtr_InitializeErrorMessages1_Public_Static_Void_0;
	}
}
