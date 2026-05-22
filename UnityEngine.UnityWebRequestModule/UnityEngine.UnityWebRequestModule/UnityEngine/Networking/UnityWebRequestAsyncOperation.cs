using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Networking
{
	// Token: 0x02000005 RID: 5
	public class UnityWebRequestAsyncOperation : AsyncOperation
	{
		// Token: 0x06000050 RID: 80 RVA: 0x00003688 File Offset: 0x00001888
		// Note: this type is marked as 'beforefieldinit'.
		static UnityWebRequestAsyncOperation()
		{
			Il2CppClassPointerStore<UnityWebRequestAsyncOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityWebRequestModule.dll", "UnityEngine.Networking", "UnityWebRequestAsyncOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityWebRequestAsyncOperation>.NativeClassPtr);
			UnityWebRequestAsyncOperation.NativeFieldInfoPtr__webRequest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequestAsyncOperation>.NativeClassPtr, "<webRequest>k__BackingField");
			UnityWebRequestAsyncOperation.NativeMethodInfoPtr_set_webRequest_Internal_set_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequestAsyncOperation>.NativeClassPtr, 100663320);
			UnityWebRequestAsyncOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequestAsyncOperation>.NativeClassPtr, 100663321);
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00002230 File Offset: 0x00000430
		// (set) Token: 0x06000051 RID: 81 RVA: 0x000036F4 File Offset: 0x000018F4
		public unsafe UnityWebRequest webRequest
		{
			get
			{
				return this._webRequest_k__BackingField;
			}
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequestAsyncOperation.NativeMethodInfoPtr_set_webRequest_Internal_set_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003738 File Offset: 0x00001938
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequestAsyncOperation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityWebRequestAsyncOperation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequestAsyncOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002208 File Offset: 0x00000408
		public UnityWebRequestAsyncOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00003774 File Offset: 0x00001974
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00002211 File Offset: 0x00000411
		public unsafe UnityWebRequest _webRequest_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequestAsyncOperation.NativeFieldInfoPtr__webRequest_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequestAsyncOperation.NativeFieldInfoPtr__webRequest_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr__webRequest_k__BackingField;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_set_webRequest_Internal_set_Void_UnityWebRequest_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
