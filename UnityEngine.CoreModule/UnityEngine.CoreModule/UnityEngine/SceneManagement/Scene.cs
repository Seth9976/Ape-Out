using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.SceneManagement
{
	// Token: 0x0200013B RID: 315
	[Serializable]
	[StructLayout(2)]
	public struct Scene
	{
		// Token: 0x060018D7 RID: 6359 RVA: 0x000602F0 File Offset: 0x0005E4F0
		// Note: this type is marked as 'beforefieldinit'.
		static Scene()
		{
			Il2CppClassPointerStore<Scene>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.SceneManagement", "Scene");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Scene>.NativeClassPtr);
			Scene.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scene>.NativeClassPtr, "m_Handle");
			Scene.NativeMethodInfoPtr_IsValidInternal_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100665593);
			Scene.NativeMethodInfoPtr_GetNameInternal_Private_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100665594);
			Scene.NativeMethodInfoPtr_GetIsLoadedInternal_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100665595);
			Scene.NativeMethodInfoPtr_GetBuildIndexInternal_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100665596);
			Scene.NativeMethodInfoPtr_GetRootCountInternal_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100665597);
			Scene.NativeMethodInfoPtr_GetRootGameObjectsInternal_Private_Static_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100665598);
			Scene.NativeMethodInfoPtr_get_handle_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100665599);
			Scene.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100665600);
			Scene.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100665601);
			Scene.NativeMethodInfoPtr_get_isLoaded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100665602);
			Scene.NativeMethodInfoPtr_get_buildIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100665603);
			Scene.NativeMethodInfoPtr_get_rootCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100665604);
			Scene.NativeMethodInfoPtr_GetRootGameObjects_Public_Il2CppReferenceArray_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100665605);
			Scene.NativeMethodInfoPtr_GetRootGameObjects_Public_Void_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100665606);
			Scene.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100665607);
			Scene.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100665608);
			Scene.GetPathInternalDelegateField = IL2CPP.ResolveICall<Scene.GetPathInternalDelegate>("UnityEngine.SceneManagement.Scene::GetPathInternal");
			Scene.SetNameInternalDelegateField = IL2CPP.ResolveICall<Scene.SetNameInternalDelegate>("UnityEngine.SceneManagement.Scene::SetNameInternal");
			Scene.GetGUIDInternalDelegateField = IL2CPP.ResolveICall<Scene.GetGUIDInternalDelegate>("UnityEngine.SceneManagement.Scene::GetGUIDInternal");
			Scene.IsSubSceneDelegateField = IL2CPP.ResolveICall<Scene.IsSubSceneDelegate>("UnityEngine.SceneManagement.Scene::IsSubScene");
			Scene.SetIsSubSceneDelegateField = IL2CPP.ResolveICall<Scene.SetIsSubSceneDelegate>("UnityEngine.SceneManagement.Scene::SetIsSubScene");
			Scene.GetLoadingStateInternalDelegateField = IL2CPP.ResolveICall<Scene.GetLoadingStateInternalDelegate>("UnityEngine.SceneManagement.Scene::GetLoadingStateInternal");
			Scene.GetIsDirtyInternalDelegateField = IL2CPP.ResolveICall<Scene.GetIsDirtyInternalDelegate>("UnityEngine.SceneManagement.Scene::GetIsDirtyInternal");
			Scene.GetDirtyIDDelegateField = IL2CPP.ResolveICall<Scene.GetDirtyIDDelegate>("UnityEngine.SceneManagement.Scene::GetDirtyID");
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x000604EC File Offset: 0x0005E6EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501638, XrefRangeEnd = 501642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidInternal(int sceneHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sceneHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_IsValidInternal_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x0006052C File Offset: 0x0005E72C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501642, XrefRangeEnd = 501646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetNameInternal(int sceneHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sceneHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetNameInternal_Private_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x00060564 File Offset: 0x0005E764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501646, XrefRangeEnd = 501650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetIsLoadedInternal(int sceneHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sceneHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetIsLoadedInternal_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x000605A4 File Offset: 0x0005E7A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501650, XrefRangeEnd = 501654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetBuildIndexInternal(int sceneHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sceneHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetBuildIndexInternal_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x000605E4 File Offset: 0x0005E7E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501654, XrefRangeEnd = 501658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetRootCountInternal(int sceneHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sceneHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetRootCountInternal_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x00060624 File Offset: 0x0005E824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501658, XrefRangeEnd = 501662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetRootGameObjectsInternal(int sceneHandle, Object resultRootList)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sceneHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultRootList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetRootGameObjectsInternal_Private_Static_Void_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x060018DE RID: 6366 RVA: 0x00060668 File Offset: 0x0005E868
		public unsafe int handle
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_get_handle_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x00060698 File Offset: 0x0005E898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501662, XrefRangeEnd = 501666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_IsValid_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x060018E0 RID: 6368 RVA: 0x000606C8 File Offset: 0x0005E8C8
		// (set) Token: 0x060018F4 RID: 6388 RVA: 0x0000D1DD File Offset: 0x0000B3DD
		public unsafe string name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501666, XrefRangeEnd = 501670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_get_name_Public_get_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				Scene.SetNameInternal(this.handle, value);
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x060018E1 RID: 6369 RVA: 0x000606F4 File Offset: 0x0005E8F4
		public unsafe bool isLoaded
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501670, XrefRangeEnd = 501674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_get_isLoaded_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x060018E2 RID: 6370 RVA: 0x00060724 File Offset: 0x0005E924
		public unsafe int buildIndex
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501674, XrefRangeEnd = 501678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_get_buildIndex_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x060018E3 RID: 6371 RVA: 0x00060754 File Offset: 0x0005E954
		public unsafe int rootCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501678, XrefRangeEnd = 501682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_get_rootCount_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x00060784 File Offset: 0x0005E984
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 501697, RefRangeEnd = 501699, XrefRangeStart = 501682, XrefRangeEnd = 501697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<GameObject> GetRootGameObjects()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetRootGameObjects_Public_Il2CppReferenceArray_1_GameObject_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr3) : null;
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x000607B8 File Offset: 0x0005E9B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 501719, RefRangeEnd = 501720, XrefRangeStart = 501699, XrefRangeEnd = 501719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetRootGameObjects(List<GameObject> rootGameObjects)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootGameObjects);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetRootGameObjects_Public_Void_List_1_GameObject_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x000607F0 File Offset: 0x0005E9F0
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x00060820 File Offset: 0x0005EA20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501720, XrefRangeEnd = 501722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x0000D176 File Offset: 0x0000B376
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Scene>.NativeClassPtr, ref this));
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x00060864 File Offset: 0x0005EA64
		public static string GetPathInternal(int sceneHandle)
		{
			IntPtr intPtr = Scene.GetPathInternalDelegateField(sceneHandle);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x0000D188 File Offset: 0x0000B388
		public static void SetNameInternal(int sceneHandle, string name)
		{
			Scene.SetNameInternalDelegateField(sceneHandle, IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x00060884 File Offset: 0x0005EA84
		public static string GetGUIDInternal(int sceneHandle)
		{
			IntPtr intPtr = Scene.GetGUIDInternalDelegateField(sceneHandle);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x0000D19B File Offset: 0x0000B39B
		public static bool IsSubScene(int sceneHandle)
		{
			return Scene.IsSubSceneDelegateField(sceneHandle);
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x0000D1A8 File Offset: 0x0000B3A8
		public static void SetIsSubScene(int sceneHandle, bool value)
		{
			Scene.SetIsSubSceneDelegateField(sceneHandle, value);
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x0000D1B6 File Offset: 0x0000B3B6
		public static Scene.LoadingState GetLoadingStateInternal(int sceneHandle)
		{
			return Scene.GetLoadingStateInternalDelegateField(sceneHandle);
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x0000D1C3 File Offset: 0x0000B3C3
		public static bool GetIsDirtyInternal(int sceneHandle)
		{
			return Scene.GetIsDirtyInternalDelegateField(sceneHandle);
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x0000D1D0 File Offset: 0x0000B3D0
		public static int GetDirtyID(int sceneHandle)
		{
			return Scene.GetDirtyIDDelegateField(sceneHandle);
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x060018F1 RID: 6385 RVA: 0x000608A4 File Offset: 0x0005EAA4
		public Scene.LoadingState loadingState
		{
			get
			{
				return Scene.GetLoadingStateInternal(this.handle);
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x060018F2 RID: 6386 RVA: 0x000608C4 File Offset: 0x0005EAC4
		public string guid
		{
			get
			{
				return Scene.GetGUIDInternal(this.handle);
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x060018F3 RID: 6387 RVA: 0x000608E4 File Offset: 0x0005EAE4
		public string path
		{
			get
			{
				return Scene.GetPathInternal(this.handle);
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x060018F5 RID: 6389 RVA: 0x00060904 File Offset: 0x0005EB04
		public bool isDirty
		{
			get
			{
				return Scene.GetIsDirtyInternal(this.handle);
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x060018F6 RID: 6390 RVA: 0x00060924 File Offset: 0x0005EB24
		public int dirtyID
		{
			get
			{
				return Scene.GetDirtyID(this.handle);
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x060018F7 RID: 6391 RVA: 0x00060944 File Offset: 0x0005EB44
		// (set) Token: 0x060018F8 RID: 6392 RVA: 0x0000D1ED File Offset: 0x0000B3ED
		public bool isSubScene
		{
			get
			{
				return Scene.IsSubScene(this.handle);
			}
			set
			{
				Scene.SetIsSubScene(this.handle, value);
			}
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x00060964 File Offset: 0x0005EB64
		public static bool operator ==(Scene lhs, Scene rhs)
		{
			return lhs.handle == rhs.handle;
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x00060988 File Offset: 0x0005EB88
		public static bool operator !=(Scene lhs, Scene rhs)
		{
			return lhs.handle != rhs.handle;
		}

		// Token: 0x04001325 RID: 4901
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04001326 RID: 4902
		private static readonly IntPtr NativeMethodInfoPtr_IsValidInternal_Private_Static_Boolean_Int32_0;

		// Token: 0x04001327 RID: 4903
		private static readonly IntPtr NativeMethodInfoPtr_GetNameInternal_Private_Static_String_Int32_0;

		// Token: 0x04001328 RID: 4904
		private static readonly IntPtr NativeMethodInfoPtr_GetIsLoadedInternal_Private_Static_Boolean_Int32_0;

		// Token: 0x04001329 RID: 4905
		private static readonly IntPtr NativeMethodInfoPtr_GetBuildIndexInternal_Private_Static_Int32_Int32_0;

		// Token: 0x0400132A RID: 4906
		private static readonly IntPtr NativeMethodInfoPtr_GetRootCountInternal_Private_Static_Int32_Int32_0;

		// Token: 0x0400132B RID: 4907
		private static readonly IntPtr NativeMethodInfoPtr_GetRootGameObjectsInternal_Private_Static_Void_Int32_Object_0;

		// Token: 0x0400132C RID: 4908
		private static readonly IntPtr NativeMethodInfoPtr_get_handle_Public_get_Int32_0;

		// Token: 0x0400132D RID: 4909
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

		// Token: 0x0400132E RID: 4910
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x0400132F RID: 4911
		private static readonly IntPtr NativeMethodInfoPtr_get_isLoaded_Public_get_Boolean_0;

		// Token: 0x04001330 RID: 4912
		private static readonly IntPtr NativeMethodInfoPtr_get_buildIndex_Public_get_Int32_0;

		// Token: 0x04001331 RID: 4913
		private static readonly IntPtr NativeMethodInfoPtr_get_rootCount_Public_get_Int32_0;

		// Token: 0x04001332 RID: 4914
		private static readonly IntPtr NativeMethodInfoPtr_GetRootGameObjects_Public_Il2CppReferenceArray_1_GameObject_0;

		// Token: 0x04001333 RID: 4915
		private static readonly IntPtr NativeMethodInfoPtr_GetRootGameObjects_Public_Void_List_1_GameObject_0;

		// Token: 0x04001334 RID: 4916
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001335 RID: 4917
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001336 RID: 4918
		[FieldOffset(0)]
		public int m_Handle;

		// Token: 0x04001337 RID: 4919
		private static readonly Scene.GetPathInternalDelegate GetPathInternalDelegateField;

		// Token: 0x04001338 RID: 4920
		private static readonly Scene.SetNameInternalDelegate SetNameInternalDelegateField;

		// Token: 0x04001339 RID: 4921
		private static readonly Scene.GetGUIDInternalDelegate GetGUIDInternalDelegateField;

		// Token: 0x0400133A RID: 4922
		private static readonly Scene.IsSubSceneDelegate IsSubSceneDelegateField;

		// Token: 0x0400133B RID: 4923
		private static readonly Scene.SetIsSubSceneDelegate SetIsSubSceneDelegateField;

		// Token: 0x0400133C RID: 4924
		private static readonly Scene.GetLoadingStateInternalDelegate GetLoadingStateInternalDelegateField;

		// Token: 0x0400133D RID: 4925
		private static readonly Scene.GetIsDirtyInternalDelegate GetIsDirtyInternalDelegateField;

		// Token: 0x0400133E RID: 4926
		private static readonly Scene.GetDirtyIDDelegate GetDirtyIDDelegateField;

		// Token: 0x020008A6 RID: 2214
		public enum LoadingState
		{
			// Token: 0x04001FA0 RID: 8096
			NotLoaded,
			// Token: 0x04001FA1 RID: 8097
			Loading,
			// Token: 0x04001FA2 RID: 8098
			Loaded,
			// Token: 0x04001FA3 RID: 8099
			Unloading
		}

		// Token: 0x020008A7 RID: 2215
		// (Invoke) Token: 0x06002FC7 RID: 12231
		private delegate IntPtr GetPathInternalDelegate(int sceneHandle);

		// Token: 0x020008A8 RID: 2216
		// (Invoke) Token: 0x06002FC9 RID: 12233
		private delegate void SetNameInternalDelegate(int sceneHandle, IntPtr name);

		// Token: 0x020008A9 RID: 2217
		// (Invoke) Token: 0x06002FCB RID: 12235
		private delegate IntPtr GetGUIDInternalDelegate(int sceneHandle);

		// Token: 0x020008AA RID: 2218
		// (Invoke) Token: 0x06002FCD RID: 12237
		private delegate bool IsSubSceneDelegate(int sceneHandle);

		// Token: 0x020008AB RID: 2219
		// (Invoke) Token: 0x06002FCF RID: 12239
		private delegate void SetIsSubSceneDelegate(int sceneHandle, bool value);

		// Token: 0x020008AC RID: 2220
		// (Invoke) Token: 0x06002FD1 RID: 12241
		private delegate Scene.LoadingState GetLoadingStateInternalDelegate(int sceneHandle);

		// Token: 0x020008AD RID: 2221
		// (Invoke) Token: 0x06002FD3 RID: 12243
		private delegate bool GetIsDirtyInternalDelegate(int sceneHandle);

		// Token: 0x020008AE RID: 2222
		// (Invoke) Token: 0x06002FD5 RID: 12245
		private delegate int GetDirtyIDDelegate(int sceneHandle);
	}
}
