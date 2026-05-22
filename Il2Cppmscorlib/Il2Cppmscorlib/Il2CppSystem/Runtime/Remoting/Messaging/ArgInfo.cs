using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003E4 RID: 996
	public class ArgInfo : Object
	{
		// Token: 0x06004013 RID: 16403 RVA: 0x0012C3A8 File Offset: 0x0012A5A8
		// Note: this type is marked as 'beforefieldinit'.
		static ArgInfo()
		{
			Il2CppClassPointerStore<ArgInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "ArgInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArgInfo>.NativeClassPtr);
			ArgInfo.NativeFieldInfoPtr__paramMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgInfo>.NativeClassPtr, "_paramMap");
			ArgInfo.NativeFieldInfoPtr__inoutArgCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgInfo>.NativeClassPtr, "_inoutArgCount");
			ArgInfo.NativeFieldInfoPtr__method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgInfo>.NativeClassPtr, "_method");
			ArgInfo.NativeMethodInfoPtr__ctor_Public_Void_MethodBase_ArgInfoType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgInfo>.NativeClassPtr, 100672738);
			ArgInfo.NativeMethodInfoPtr_GetInOutArgs_Public_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgInfo>.NativeClassPtr, 100672739);
		}

		// Token: 0x06004014 RID: 16404 RVA: 0x0012C43C File Offset: 0x0012A63C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223920, RefRangeEnd = 223922, XrefRangeStart = 223915, XrefRangeEnd = 223920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgInfo(MethodBase method, ArgInfoType type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgInfo.NativeMethodInfoPtr__ctor_Public_Void_MethodBase_ArgInfoType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004015 RID: 16405 RVA: 0x0012C498 File Offset: 0x0012A698
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223927, RefRangeEnd = 223929, XrefRangeStart = 223922, XrefRangeEnd = 223927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> GetInOutArgs(Il2CppReferenceArray<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgInfo.NativeMethodInfoPtr_GetInOutArgs_Public_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06004016 RID: 16406 RVA: 0x0001805D File Offset: 0x0001625D
		public ArgInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700101F RID: 4127
		// (get) Token: 0x06004017 RID: 16407 RVA: 0x0012C4E8 File Offset: 0x0012A6E8
		// (set) Token: 0x06004018 RID: 16408 RVA: 0x00018066 File Offset: 0x00016266
		public unsafe Il2CppStructArray<int> _paramMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgInfo.NativeFieldInfoPtr__paramMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgInfo.NativeFieldInfoPtr__paramMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001020 RID: 4128
		// (get) Token: 0x06004019 RID: 16409 RVA: 0x0012C518 File Offset: 0x0012A718
		// (set) Token: 0x0600401A RID: 16410 RVA: 0x00018085 File Offset: 0x00016285
		public unsafe int _inoutArgCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgInfo.NativeFieldInfoPtr__inoutArgCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgInfo.NativeFieldInfoPtr__inoutArgCount)) = value;
			}
		}

		// Token: 0x17001021 RID: 4129
		// (get) Token: 0x0600401B RID: 16411 RVA: 0x0012C540 File Offset: 0x0012A740
		// (set) Token: 0x0600401C RID: 16412 RVA: 0x000180A0 File Offset: 0x000162A0
		public unsafe MethodBase _method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgInfo.NativeFieldInfoPtr__method);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgInfo.NativeFieldInfoPtr__method), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400349F RID: 13471
		private static readonly IntPtr NativeFieldInfoPtr__paramMap;

		// Token: 0x040034A0 RID: 13472
		private static readonly IntPtr NativeFieldInfoPtr__inoutArgCount;

		// Token: 0x040034A1 RID: 13473
		private static readonly IntPtr NativeFieldInfoPtr__method;

		// Token: 0x040034A2 RID: 13474
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MethodBase_ArgInfoType_0;

		// Token: 0x040034A3 RID: 13475
		private static readonly IntPtr NativeMethodInfoPtr_GetInOutArgs_Public_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_0;
	}
}
