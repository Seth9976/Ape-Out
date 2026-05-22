using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.Cache
{
	// Token: 0x02000170 RID: 368
	public class RequestCacheBinding : Object
	{
		// Token: 0x060016F4 RID: 5876 RVA: 0x000669FC File Offset: 0x00064BFC
		// Note: this type is marked as 'beforefieldinit'.
		static RequestCacheBinding()
		{
			Il2CppClassPointerStore<RequestCacheBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Cache", "RequestCacheBinding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestCacheBinding>.NativeClassPtr);
			RequestCacheBinding.NativeFieldInfoPtr_m_RequestCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestCacheBinding>.NativeClassPtr, "m_RequestCache");
			RequestCacheBinding.NativeFieldInfoPtr_m_CacheValidator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestCacheBinding>.NativeClassPtr, "m_CacheValidator");
			RequestCacheBinding.NativeMethodInfoPtr_get_Cache_Internal_get_RequestCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestCacheBinding>.NativeClassPtr, 100666526);
			RequestCacheBinding.NativeMethodInfoPtr_get_Validator_Internal_get_RequestCacheValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestCacheBinding>.NativeClassPtr, 100666527);
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x060016F5 RID: 5877 RVA: 0x00066A7C File Offset: 0x00064C7C
		public unsafe RequestCache Cache
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestCacheBinding.NativeMethodInfoPtr_get_Cache_Internal_get_RequestCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RequestCache>(intPtr3) : null;
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x060016F6 RID: 5878 RVA: 0x00066ABC File Offset: 0x00064CBC
		public unsafe RequestCacheValidator Validator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestCacheBinding.NativeMethodInfoPtr_get_Validator_Internal_get_RequestCacheValidator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RequestCacheValidator>(intPtr3) : null;
			}
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x0000B71D File Offset: 0x0000991D
		public RequestCacheBinding(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x060016F8 RID: 5880 RVA: 0x00066AFC File Offset: 0x00064CFC
		// (set) Token: 0x060016F9 RID: 5881 RVA: 0x0000B726 File Offset: 0x00009926
		public unsafe RequestCache m_RequestCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestCacheBinding.NativeFieldInfoPtr_m_RequestCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestCache>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestCacheBinding.NativeFieldInfoPtr_m_RequestCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x060016FA RID: 5882 RVA: 0x00066B2C File Offset: 0x00064D2C
		// (set) Token: 0x060016FB RID: 5883 RVA: 0x0000B745 File Offset: 0x00009945
		public unsafe RequestCacheValidator m_CacheValidator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestCacheBinding.NativeFieldInfoPtr_m_CacheValidator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestCacheValidator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestCacheBinding.NativeFieldInfoPtr_m_CacheValidator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001249 RID: 4681
		private static readonly IntPtr NativeFieldInfoPtr_m_RequestCache;

		// Token: 0x0400124A RID: 4682
		private static readonly IntPtr NativeFieldInfoPtr_m_CacheValidator;

		// Token: 0x0400124B RID: 4683
		private static readonly IntPtr NativeMethodInfoPtr_get_Cache_Internal_get_RequestCache_0;

		// Token: 0x0400124C RID: 4684
		private static readonly IntPtr NativeMethodInfoPtr_get_Validator_Internal_get_RequestCacheValidator_0;
	}
}
