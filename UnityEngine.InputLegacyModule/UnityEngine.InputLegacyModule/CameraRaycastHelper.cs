using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000006 RID: 6
	public class CameraRaycastHelper : Object
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00002894 File Offset: 0x00000A94
		// Note: this type is marked as 'beforefieldinit'.
		static CameraRaycastHelper()
		{
			Il2CppClassPointerStore<CameraRaycastHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputLegacyModule.dll", "UnityEngine", "CameraRaycastHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraRaycastHelper>.NativeClassPtr);
			CameraRaycastHelper.NativeMethodInfoPtr_RaycastTry_Internal_Static_GameObject_Camera_Ray_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRaycastHelper>.NativeClassPtr, 100663303);
			CameraRaycastHelper.NativeMethodInfoPtr_RaycastTry2D_Internal_Static_GameObject_Camera_Ray_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRaycastHelper>.NativeClassPtr, 100663304);
			CameraRaycastHelper.NativeMethodInfoPtr_RaycastTry_Injected_Private_Static_GameObject_Camera_byref_Ray_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRaycastHelper>.NativeClassPtr, 100663305);
			CameraRaycastHelper.NativeMethodInfoPtr_RaycastTry2D_Injected_Private_Static_GameObject_Camera_byref_Ray_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRaycastHelper>.NativeClassPtr, 100663306);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002914 File Offset: 0x00000B14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 511767, RefRangeEnd = 511768, XrefRangeStart = 511765, XrefRangeEnd = 511767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject RaycastTry(Camera cam, Ray ray, float distance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraRaycastHelper.NativeMethodInfoPtr_RaycastTry_Internal_Static_GameObject_Camera_Ray_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002984 File Offset: 0x00000B84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 511770, RefRangeEnd = 511771, XrefRangeStart = 511768, XrefRangeEnd = 511770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject RaycastTry2D(Camera cam, Ray ray, float distance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraRaycastHelper.NativeMethodInfoPtr_RaycastTry2D_Internal_Static_GameObject_Camera_Ray_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000029F4 File Offset: 0x00000BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511771, XrefRangeEnd = 511775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject RaycastTry_Injected(Camera cam, ref Ray ray, float distance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraRaycastHelper.NativeMethodInfoPtr_RaycastTry_Injected_Private_Static_GameObject_Camera_byref_Ray_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002A64 File Offset: 0x00000C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511775, XrefRangeEnd = 511779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject RaycastTry2D_Injected(Camera cam, ref Ray ray, float distance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraRaycastHelper.NativeMethodInfoPtr_RaycastTry2D_Injected_Private_Static_GameObject_Camera_byref_Ray_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000020EE File Offset: 0x000002EE
		public CameraRaycastHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_RaycastTry_Internal_Static_GameObject_Camera_Ray_Single_Int32_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_RaycastTry2D_Internal_Static_GameObject_Camera_Ray_Single_Int32_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_RaycastTry_Injected_Private_Static_GameObject_Camera_byref_Ray_Single_Int32_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_RaycastTry2D_Injected_Private_Static_GameObject_Camera_byref_Ray_Single_Int32_0;
	}
}
