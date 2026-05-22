using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UI
{
	// Token: 0x0200003E RID: 62
	public class ReflectionMethodsCache : Object
	{
		// Token: 0x060007E2 RID: 2018 RVA: 0x0002591C File Offset: 0x00023B1C
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionMethodsCache()
		{
			Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "ReflectionMethodsCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr);
			ReflectionMethodsCache.NativeFieldInfoPtr_raycast3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "raycast3D");
			ReflectionMethodsCache.NativeFieldInfoPtr_raycast3DAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "raycast3DAll");
			ReflectionMethodsCache.NativeFieldInfoPtr_getRaycastNonAlloc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "getRaycastNonAlloc");
			ReflectionMethodsCache.NativeFieldInfoPtr_raycast2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "raycast2D");
			ReflectionMethodsCache.NativeFieldInfoPtr_getRayIntersectionAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "getRayIntersectionAll");
			ReflectionMethodsCache.NativeFieldInfoPtr_getRayIntersectionAllNonAlloc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "getRayIntersectionAllNonAlloc");
			ReflectionMethodsCache.NativeFieldInfoPtr_s_ReflectionMethodsCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "s_ReflectionMethodsCache");
			ReflectionMethodsCache.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, 100664569);
			ReflectionMethodsCache.NativeMethodInfoPtr_get_Singleton_Public_Static_get_ReflectionMethodsCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, 100664570);
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00025A00 File Offset: 0x00023C00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 529611, RefRangeEnd = 529612, XrefRangeStart = 529405, XrefRangeEnd = 529611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectionMethodsCache()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x00025A3C File Offset: 0x00023C3C
		public unsafe static ReflectionMethodsCache Singleton
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 529624, RefRangeEnd = 529636, XrefRangeStart = 529612, XrefRangeEnd = 529624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.NativeMethodInfoPtr_get_Singleton_Public_Static_get_ReflectionMethodsCache_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReflectionMethodsCache>(intPtr3) : null;
			}
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00004B16 File Offset: 0x00002D16
		public ReflectionMethodsCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x00025A70 File Offset: 0x00023C70
		// (set) Token: 0x060007E7 RID: 2023 RVA: 0x00004B1F File Offset: 0x00002D1F
		public unsafe ReflectionMethodsCache.Raycast3DCallback raycast3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_raycast3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionMethodsCache.Raycast3DCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_raycast3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x00025AA0 File Offset: 0x00023CA0
		// (set) Token: 0x060007E9 RID: 2025 RVA: 0x00004B3E File Offset: 0x00002D3E
		public unsafe ReflectionMethodsCache.RaycastAllCallback raycast3DAll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_raycast3DAll);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionMethodsCache.RaycastAllCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_raycast3DAll), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x00025AD0 File Offset: 0x00023CD0
		// (set) Token: 0x060007EB RID: 2027 RVA: 0x00004B5D File Offset: 0x00002D5D
		public unsafe ReflectionMethodsCache.GetRaycastNonAllocCallback getRaycastNonAlloc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_getRaycastNonAlloc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionMethodsCache.GetRaycastNonAllocCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_getRaycastNonAlloc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x00025B00 File Offset: 0x00023D00
		// (set) Token: 0x060007ED RID: 2029 RVA: 0x00004B7C File Offset: 0x00002D7C
		public unsafe ReflectionMethodsCache.Raycast2DCallback raycast2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_raycast2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionMethodsCache.Raycast2DCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_raycast2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x00025B30 File Offset: 0x00023D30
		// (set) Token: 0x060007EF RID: 2031 RVA: 0x00004B9B File Offset: 0x00002D9B
		public unsafe ReflectionMethodsCache.GetRayIntersectionAllCallback getRayIntersectionAll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_getRayIntersectionAll);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionMethodsCache.GetRayIntersectionAllCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_getRayIntersectionAll), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x00025B60 File Offset: 0x00023D60
		// (set) Token: 0x060007F1 RID: 2033 RVA: 0x00004BBA File Offset: 0x00002DBA
		public unsafe ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback getRayIntersectionAllNonAlloc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_getRayIntersectionAllNonAlloc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_getRayIntersectionAllNonAlloc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x00025B90 File Offset: 0x00023D90
		// (set) Token: 0x060007F3 RID: 2035 RVA: 0x00004BD9 File Offset: 0x00002DD9
		public unsafe static ReflectionMethodsCache s_ReflectionMethodsCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectionMethodsCache.NativeFieldInfoPtr_s_ReflectionMethodsCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionMethodsCache>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectionMethodsCache.NativeFieldInfoPtr_s_ReflectionMethodsCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeFieldInfoPtr_raycast3D;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeFieldInfoPtr_raycast3DAll;

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeFieldInfoPtr_getRaycastNonAlloc;

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeFieldInfoPtr_raycast2D;

		// Token: 0x0400060E RID: 1550
		private static readonly IntPtr NativeFieldInfoPtr_getRayIntersectionAll;

		// Token: 0x0400060F RID: 1551
		private static readonly IntPtr NativeFieldInfoPtr_getRayIntersectionAllNonAlloc;

		// Token: 0x04000610 RID: 1552
		private static readonly IntPtr NativeFieldInfoPtr_s_ReflectionMethodsCache;

		// Token: 0x04000611 RID: 1553
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeMethodInfoPtr_get_Singleton_Public_Static_get_ReflectionMethodsCache_0;

		// Token: 0x020000B3 RID: 179
		public sealed class Raycast3DCallback : MulticastDelegate
		{
			// Token: 0x06000C58 RID: 3160 RVA: 0x000352B0 File Offset: 0x000334B0
			// Note: this type is marked as 'beforefieldinit'.
			static Raycast3DCallback()
			{
				Il2CppClassPointerStore<ReflectionMethodsCache.Raycast3DCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "Raycast3DCallback");
				ReflectionMethodsCache.Raycast3DCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.Raycast3DCallback>.NativeClassPtr, 100664572);
				ReflectionMethodsCache.Raycast3DCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Ray_byref_RaycastHit_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.Raycast3DCallback>.NativeClassPtr, 100664573);
				ReflectionMethodsCache.Raycast3DCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_byref_RaycastHit_Single_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.Raycast3DCallback>.NativeClassPtr, 100664574);
				ReflectionMethodsCache.Raycast3DCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_RaycastHit_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.Raycast3DCallback>.NativeClassPtr, 100664575);
			}

			// Token: 0x06000C59 RID: 3161 RVA: 0x00035324 File Offset: 0x00033524
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Raycast3DCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionMethodsCache.Raycast3DCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.Raycast3DCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C5A RID: 3162 RVA: 0x00035380 File Offset: 0x00033580
			[CallerCount(0)]
			public unsafe bool Invoke(Ray r, out RaycastHit hit, float f, int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.Raycast3DCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Ray_byref_RaycastHit_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000C5B RID: 3163 RVA: 0x000353F4 File Offset: 0x000335F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529333, XrefRangeEnd = 529346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Ray r, out RaycastHit hit, float f, int i, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.Raycast3DCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_byref_RaycastHit_Single_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000C5C RID: 3164 RVA: 0x00035490 File Offset: 0x00033690
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool EndInvoke(out RaycastHit hit, IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &hit;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.Raycast3DCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_RaycastHit_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000C5D RID: 3165 RVA: 0x00006AD8 File Offset: 0x00004CD8
			public Raycast3DCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040009A9 RID: 2473
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040009AA RID: 2474
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Ray_byref_RaycastHit_Single_Int32_0;

			// Token: 0x040009AB RID: 2475
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_byref_RaycastHit_Single_Int32_AsyncCallback_Object_0;

			// Token: 0x040009AC RID: 2476
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_RaycastHit_IAsyncResult_0;
		}

		// Token: 0x020000B4 RID: 180
		public sealed class RaycastAllCallback : MulticastDelegate
		{
			// Token: 0x06000C5E RID: 3166 RVA: 0x000354EC File Offset: 0x000336EC
			// Note: this type is marked as 'beforefieldinit'.
			static RaycastAllCallback()
			{
				Il2CppClassPointerStore<ReflectionMethodsCache.RaycastAllCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "RaycastAllCallback");
				ReflectionMethodsCache.RaycastAllCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.RaycastAllCallback>.NativeClassPtr, 100664576);
				ReflectionMethodsCache.RaycastAllCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit_Ray_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.RaycastAllCallback>.NativeClassPtr, 100664577);
				ReflectionMethodsCache.RaycastAllCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Single_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.RaycastAllCallback>.NativeClassPtr, 100664578);
				ReflectionMethodsCache.RaycastAllCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.RaycastAllCallback>.NativeClassPtr, 100664579);
			}

			// Token: 0x06000C5F RID: 3167 RVA: 0x00035560 File Offset: 0x00033760
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RaycastAllCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionMethodsCache.RaycastAllCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.RaycastAllCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C60 RID: 3168 RVA: 0x000355BC File Offset: 0x000337BC
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 529346, RefRangeEnd = 529350, XrefRangeStart = 529346, XrefRangeEnd = 529346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<RaycastHit> Invoke(Ray r, float f, int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.RaycastAllCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit_Ray_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
			}

			// Token: 0x06000C61 RID: 3169 RVA: 0x00035624 File Offset: 0x00033824
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529350, XrefRangeEnd = 529360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.RaycastAllCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Single_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000C62 RID: 3170 RVA: 0x000356B4 File Offset: 0x000338B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<RaycastHit> EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.RaycastAllCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
				}
			}

			// Token: 0x06000C63 RID: 3171 RVA: 0x00006AE1 File Offset: 0x00004CE1
			public RaycastAllCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000C64 RID: 3172 RVA: 0x00006AEA File Offset: 0x00004CEA
			public static implicit operator ReflectionMethodsCache.RaycastAllCallback(Func<Ray, float, int, Il2CppStructArray<RaycastHit>> A_0)
			{
				return DelegateSupport.ConvertDelegate<ReflectionMethodsCache.RaycastAllCallback>(A_0);
			}

			// Token: 0x06000C65 RID: 3173 RVA: 0x00006AF2 File Offset: 0x00004CF2
			public static ReflectionMethodsCache.RaycastAllCallback operator +(ReflectionMethodsCache.RaycastAllCallback A_0, ReflectionMethodsCache.RaycastAllCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ReflectionMethodsCache.RaycastAllCallback>();
			}

			// Token: 0x06000C66 RID: 3174 RVA: 0x00006B00 File Offset: 0x00004D00
			public static ReflectionMethodsCache.RaycastAllCallback operator -(ReflectionMethodsCache.RaycastAllCallback A_0, ReflectionMethodsCache.RaycastAllCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ReflectionMethodsCache.RaycastAllCallback>();
				}
				return delegate2;
			}

			// Token: 0x040009AD RID: 2477
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040009AE RID: 2478
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit_Ray_Single_Int32_0;

			// Token: 0x040009AF RID: 2479
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Single_Int32_AsyncCallback_Object_0;

			// Token: 0x040009B0 RID: 2480
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit_IAsyncResult_0;
		}

		// Token: 0x020000B5 RID: 181
		public sealed class GetRaycastNonAllocCallback : MulticastDelegate
		{
			// Token: 0x06000C67 RID: 3175 RVA: 0x00035704 File Offset: 0x00033904
			// Note: this type is marked as 'beforefieldinit'.
			static GetRaycastNonAllocCallback()
			{
				Il2CppClassPointerStore<ReflectionMethodsCache.GetRaycastNonAllocCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "GetRaycastNonAllocCallback");
				ReflectionMethodsCache.GetRaycastNonAllocCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRaycastNonAllocCallback>.NativeClassPtr, 100664580);
				ReflectionMethodsCache.GetRaycastNonAllocCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRaycastNonAllocCallback>.NativeClassPtr, 100664581);
				ReflectionMethodsCache.GetRaycastNonAllocCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRaycastNonAllocCallback>.NativeClassPtr, 100664582);
				ReflectionMethodsCache.GetRaycastNonAllocCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRaycastNonAllocCallback>.NativeClassPtr, 100664583);
			}

			// Token: 0x06000C68 RID: 3176 RVA: 0x00035778 File Offset: 0x00033978
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetRaycastNonAllocCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionMethodsCache.GetRaycastNonAllocCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRaycastNonAllocCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C69 RID: 3177 RVA: 0x000357D4 File Offset: 0x000339D4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 529360, RefRangeEnd = 529362, XrefRangeStart = 529360, XrefRangeEnd = 529360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int Invoke(Ray r, Il2CppStructArray<RaycastHit> results, float f, int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRaycastNonAllocCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000C6A RID: 3178 RVA: 0x0003584C File Offset: 0x00033A4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529362, XrefRangeEnd = 529372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Ray r, Il2CppStructArray<RaycastHit> results, float f, int i, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRaycastNonAllocCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000C6B RID: 3179 RVA: 0x000358EC File Offset: 0x00033AEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRaycastNonAllocCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000C6C RID: 3180 RVA: 0x00006B11 File Offset: 0x00004D11
			public GetRaycastNonAllocCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000C6D RID: 3181 RVA: 0x00006B1A File Offset: 0x00004D1A
			public static implicit operator ReflectionMethodsCache.GetRaycastNonAllocCallback(Func<Ray, Il2CppStructArray<RaycastHit>, float, int, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<ReflectionMethodsCache.GetRaycastNonAllocCallback>(A_0);
			}

			// Token: 0x06000C6E RID: 3182 RVA: 0x00006B22 File Offset: 0x00004D22
			public static ReflectionMethodsCache.GetRaycastNonAllocCallback operator +(ReflectionMethodsCache.GetRaycastNonAllocCallback A_0, ReflectionMethodsCache.GetRaycastNonAllocCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ReflectionMethodsCache.GetRaycastNonAllocCallback>();
			}

			// Token: 0x06000C6F RID: 3183 RVA: 0x00006B30 File Offset: 0x00004D30
			public static ReflectionMethodsCache.GetRaycastNonAllocCallback operator -(ReflectionMethodsCache.GetRaycastNonAllocCallback A_0, ReflectionMethodsCache.GetRaycastNonAllocCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ReflectionMethodsCache.GetRaycastNonAllocCallback>();
				}
				return delegate2;
			}

			// Token: 0x040009B1 RID: 2481
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040009B2 RID: 2482
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_0;

			// Token: 0x040009B3 RID: 2483
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_AsyncCallback_Object_0;

			// Token: 0x040009B4 RID: 2484
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0;
		}

		// Token: 0x020000B6 RID: 182
		public sealed class Raycast2DCallback : MulticastDelegate
		{
			// Token: 0x06000C70 RID: 3184 RVA: 0x0003593C File Offset: 0x00033B3C
			// Note: this type is marked as 'beforefieldinit'.
			static Raycast2DCallback()
			{
				Il2CppClassPointerStore<ReflectionMethodsCache.Raycast2DCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "Raycast2DCallback");
				ReflectionMethodsCache.Raycast2DCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.Raycast2DCallback>.NativeClassPtr, 100664584);
				ReflectionMethodsCache.Raycast2DCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_RaycastHit2D_Vector2_Vector2_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.Raycast2DCallback>.NativeClassPtr, 100664585);
				ReflectionMethodsCache.Raycast2DCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Vector2_Vector2_Single_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.Raycast2DCallback>.NativeClassPtr, 100664586);
				ReflectionMethodsCache.Raycast2DCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_RaycastHit2D_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.Raycast2DCallback>.NativeClassPtr, 100664587);
			}

			// Token: 0x06000C71 RID: 3185 RVA: 0x000359B0 File Offset: 0x00033BB0
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Raycast2DCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionMethodsCache.Raycast2DCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.Raycast2DCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C72 RID: 3186 RVA: 0x00035A0C File Offset: 0x00033C0C
			[CallerCount(0)]
			public unsafe RaycastHit2D Invoke(Vector2 p1, Vector2 p2, float f, int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref p1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p2;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.Raycast2DCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_RaycastHit2D_Vector2_Vector2_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000C73 RID: 3187 RVA: 0x00035A80 File Offset: 0x00033C80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529372, XrefRangeEnd = 529384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Vector2 p1, Vector2 p2, float f, int i, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref p1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p2;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.Raycast2DCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Vector2_Vector2_Single_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000C74 RID: 3188 RVA: 0x00035B1C File Offset: 0x00033D1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529384, XrefRangeEnd = 529385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RaycastHit2D EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.Raycast2DCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_RaycastHit2D_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000C75 RID: 3189 RVA: 0x00006B41 File Offset: 0x00004D41
			public Raycast2DCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000C76 RID: 3190 RVA: 0x00006B4A File Offset: 0x00004D4A
			public static implicit operator ReflectionMethodsCache.Raycast2DCallback(Func<Vector2, Vector2, float, int, RaycastHit2D> A_0)
			{
				return DelegateSupport.ConvertDelegate<ReflectionMethodsCache.Raycast2DCallback>(A_0);
			}

			// Token: 0x06000C77 RID: 3191 RVA: 0x00006B52 File Offset: 0x00004D52
			public static ReflectionMethodsCache.Raycast2DCallback operator +(ReflectionMethodsCache.Raycast2DCallback A_0, ReflectionMethodsCache.Raycast2DCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ReflectionMethodsCache.Raycast2DCallback>();
			}

			// Token: 0x06000C78 RID: 3192 RVA: 0x00006B60 File Offset: 0x00004D60
			public static ReflectionMethodsCache.Raycast2DCallback operator -(ReflectionMethodsCache.Raycast2DCallback A_0, ReflectionMethodsCache.Raycast2DCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ReflectionMethodsCache.Raycast2DCallback>();
				}
				return delegate2;
			}

			// Token: 0x040009B5 RID: 2485
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040009B6 RID: 2486
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_RaycastHit2D_Vector2_Vector2_Single_Int32_0;

			// Token: 0x040009B7 RID: 2487
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Vector2_Vector2_Single_Int32_AsyncCallback_Object_0;

			// Token: 0x040009B8 RID: 2488
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_RaycastHit2D_IAsyncResult_0;
		}

		// Token: 0x020000B7 RID: 183
		public sealed class GetRayIntersectionAllCallback : MulticastDelegate
		{
			// Token: 0x06000C79 RID: 3193 RVA: 0x00035B6C File Offset: 0x00033D6C
			// Note: this type is marked as 'beforefieldinit'.
			static GetRayIntersectionAllCallback()
			{
				Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "GetRayIntersectionAllCallback");
				ReflectionMethodsCache.GetRayIntersectionAllCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllCallback>.NativeClassPtr, 100664588);
				ReflectionMethodsCache.GetRayIntersectionAllCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit2D_Ray_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllCallback>.NativeClassPtr, 100664589);
				ReflectionMethodsCache.GetRayIntersectionAllCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Single_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllCallback>.NativeClassPtr, 100664590);
				ReflectionMethodsCache.GetRayIntersectionAllCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit2D_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllCallback>.NativeClassPtr, 100664591);
			}

			// Token: 0x06000C7A RID: 3194 RVA: 0x00035BE0 File Offset: 0x00033DE0
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetRayIntersectionAllCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRayIntersectionAllCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C7B RID: 3195 RVA: 0x00035C3C File Offset: 0x00033E3C
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 529346, RefRangeEnd = 529350, XrefRangeStart = 529346, XrefRangeEnd = 529350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<RaycastHit2D> Invoke(Ray r, float f, int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRayIntersectionAllCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit2D_Ray_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr3) : null;
			}

			// Token: 0x06000C7C RID: 3196 RVA: 0x00035CA4 File Offset: 0x00033EA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529385, XrefRangeEnd = 529395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRayIntersectionAllCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Single_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000C7D RID: 3197 RVA: 0x00035D34 File Offset: 0x00033F34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<RaycastHit2D> EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRayIntersectionAllCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit2D_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr3) : null;
				}
			}

			// Token: 0x06000C7E RID: 3198 RVA: 0x00006B71 File Offset: 0x00004D71
			public GetRayIntersectionAllCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000C7F RID: 3199 RVA: 0x00006B7A File Offset: 0x00004D7A
			public static implicit operator ReflectionMethodsCache.GetRayIntersectionAllCallback(Func<Ray, float, int, Il2CppStructArray<RaycastHit2D>> A_0)
			{
				return DelegateSupport.ConvertDelegate<ReflectionMethodsCache.GetRayIntersectionAllCallback>(A_0);
			}

			// Token: 0x06000C80 RID: 3200 RVA: 0x00006B82 File Offset: 0x00004D82
			public static ReflectionMethodsCache.GetRayIntersectionAllCallback operator +(ReflectionMethodsCache.GetRayIntersectionAllCallback A_0, ReflectionMethodsCache.GetRayIntersectionAllCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ReflectionMethodsCache.GetRayIntersectionAllCallback>();
			}

			// Token: 0x06000C81 RID: 3201 RVA: 0x00006B90 File Offset: 0x00004D90
			public static ReflectionMethodsCache.GetRayIntersectionAllCallback operator -(ReflectionMethodsCache.GetRayIntersectionAllCallback A_0, ReflectionMethodsCache.GetRayIntersectionAllCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ReflectionMethodsCache.GetRayIntersectionAllCallback>();
				}
				return delegate2;
			}

			// Token: 0x040009B9 RID: 2489
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040009BA RID: 2490
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit2D_Ray_Single_Int32_0;

			// Token: 0x040009BB RID: 2491
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Single_Int32_AsyncCallback_Object_0;

			// Token: 0x040009BC RID: 2492
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit2D_IAsyncResult_0;
		}

		// Token: 0x020000B8 RID: 184
		public sealed class GetRayIntersectionAllNonAllocCallback : MulticastDelegate
		{
			// Token: 0x06000C82 RID: 3202 RVA: 0x00035D84 File Offset: 0x00033F84
			// Note: this type is marked as 'beforefieldinit'.
			static GetRayIntersectionAllNonAllocCallback()
			{
				Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "GetRayIntersectionAllNonAllocCallback");
				ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback>.NativeClassPtr, 100664592);
				ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback>.NativeClassPtr, 100664593);
				ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Il2CppStructArray_1_RaycastHit2D_Single_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback>.NativeClassPtr, 100664594);
				ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback>.NativeClassPtr, 100664595);
			}

			// Token: 0x06000C83 RID: 3203 RVA: 0x00035DF8 File Offset: 0x00033FF8
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetRayIntersectionAllNonAllocCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C84 RID: 3204 RVA: 0x00035E54 File Offset: 0x00034054
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 529360, RefRangeEnd = 529362, XrefRangeStart = 529360, XrefRangeEnd = 529362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int Invoke(Ray r, Il2CppStructArray<RaycastHit2D> results, float f, int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000C85 RID: 3205 RVA: 0x00035ECC File Offset: 0x000340CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529395, XrefRangeEnd = 529405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Ray r, Il2CppStructArray<RaycastHit2D> results, float f, int i, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Il2CppStructArray_1_RaycastHit2D_Single_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000C86 RID: 3206 RVA: 0x00035F6C File Offset: 0x0003416C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000C87 RID: 3207 RVA: 0x00006BA1 File Offset: 0x00004DA1
			public GetRayIntersectionAllNonAllocCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000C88 RID: 3208 RVA: 0x00006BAA File Offset: 0x00004DAA
			public static implicit operator ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback(Func<Ray, Il2CppStructArray<RaycastHit2D>, float, int, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback>(A_0);
			}

			// Token: 0x06000C89 RID: 3209 RVA: 0x00006BB2 File Offset: 0x00004DB2
			public static ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback operator +(ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback A_0, ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback>();
			}

			// Token: 0x06000C8A RID: 3210 RVA: 0x00006BC0 File Offset: 0x00004DC0
			public static ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback operator -(ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback A_0, ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback>();
				}
				return delegate2;
			}

			// Token: 0x040009BD RID: 2493
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040009BE RID: 2494
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_Single_Int32_0;

			// Token: 0x040009BF RID: 2495
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Il2CppStructArray_1_RaycastHit2D_Single_Int32_AsyncCallback_Object_0;

			// Token: 0x040009C0 RID: 2496
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0;
		}
	}
}
