using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Il2CppI2.Loc
{
	// Token: 0x0200026C RID: 620
	public class ResourceManager : MonoBehaviour
	{
		// Token: 0x0600467C RID: 18044 RVA: 0x00106FB0 File Offset: 0x001051B0
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceManager()
		{
			Il2CppClassPointerStore<ResourceManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "ResourceManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr);
			ResourceManager.NativeFieldInfoPtr_mInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "mInstance");
			ResourceManager.NativeFieldInfoPtr_mBundleManagers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "mBundleManagers");
			ResourceManager.NativeFieldInfoPtr_Assets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "Assets");
			ResourceManager.NativeFieldInfoPtr_mResourcesCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "mResourcesCache");
			ResourceManager.NativeMethodInfoPtr_get_pInstance_Public_Static_get_ResourceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100670431);
			ResourceManager.NativeMethodInfoPtr_MyOnLevelWasLoaded_Public_Static_Void_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100670432);
			ResourceManager.NativeMethodInfoPtr_GetAsset_Public_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100670433);
			ResourceManager.NativeMethodInfoPtr_FindAsset_Private_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100670434);
			ResourceManager.NativeMethodInfoPtr_HasAsset_Public_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100670435);
			ResourceManager.NativeMethodInfoPtr_LoadFromResources_Public_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100670436);
			ResourceManager.NativeMethodInfoPtr_LoadFromBundle_Public_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100670437);
			ResourceManager.NativeMethodInfoPtr_CleanResourceCache_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100670438);
			ResourceManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100670439);
		}

		// Token: 0x170019CB RID: 6603
		// (get) Token: 0x0600467D RID: 18045 RVA: 0x001070E4 File Offset: 0x001052E4
		public unsafe static ResourceManager pInstance
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 115331, RefRangeEnd = 115339, XrefRangeStart = 115237, XrefRangeEnd = 115331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_get_pInstance_Public_Static_get_ResourceManager_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceManager>(intPtr3) : null;
			}
		}

		// Token: 0x0600467E RID: 18046 RVA: 0x00107118 File Offset: 0x00105318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115339, XrefRangeEnd = 115352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MyOnLevelWasLoaded(Scene scene, LoadSceneMode mode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_MyOnLevelWasLoaded_Public_Static_Void_Scene_LoadSceneMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600467F RID: 18047 RVA: 0x00107158 File Offset: 0x00105358
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115370, RefRangeEnd = 115371, XrefRangeStart = 115352, XrefRangeEnd = 115370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetAsset<T>(string Name) where T : global::UnityEngine.Object
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.MethodInfoStoreGeneric_GetAsset_Public_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06004680 RID: 18048 RVA: 0x001071A4 File Offset: 0x001053A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115387, RefRangeEnd = 115388, XrefRangeStart = 115371, XrefRangeEnd = 115387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe global::UnityEngine.Object FindAsset(string Name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_FindAsset_Private_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::UnityEngine.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004681 RID: 18049 RVA: 0x001071F4 File Offset: 0x001053F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115388, XrefRangeEnd = 115390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasAsset(global::UnityEngine.Object Obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_HasAsset_Public_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004682 RID: 18050 RVA: 0x00107244 File Offset: 0x00105444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115390, XrefRangeEnd = 115478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T LoadFromResources<T>(string Path) where T : global::UnityEngine.Object
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.MethodInfoStoreGeneric_LoadFromResources_Public_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06004683 RID: 18051 RVA: 0x00107290 File Offset: 0x00105490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115478, XrefRangeEnd = 115503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T LoadFromBundle<T>(string path) where T : global::UnityEngine.Object
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.MethodInfoStoreGeneric_LoadFromBundle_Public_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06004684 RID: 18052 RVA: 0x001072DC File Offset: 0x001054DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115503, XrefRangeEnd = 115515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanResourceCache(bool unloadResources = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unloadResources;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_CleanResourceCache_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004685 RID: 18053 RVA: 0x0010731C File Offset: 0x0010551C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115515, XrefRangeEnd = 115533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004686 RID: 18054 RVA: 0x00029E89 File Offset: 0x00028089
		public ResourceManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170019C7 RID: 6599
		// (get) Token: 0x06004687 RID: 18055 RVA: 0x00107358 File Offset: 0x00105558
		// (set) Token: 0x06004688 RID: 18056 RVA: 0x00029E92 File Offset: 0x00028092
		public unsafe static ResourceManager mInstance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResourceManager.NativeFieldInfoPtr_mInstance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceManager>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourceManager.NativeFieldInfoPtr_mInstance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C8 RID: 6600
		// (get) Token: 0x06004689 RID: 18057 RVA: 0x00107380 File Offset: 0x00105580
		// (set) Token: 0x0600468A RID: 18058 RVA: 0x00029EA4 File Offset: 0x000280A4
		public unsafe List<IResourceManager_Bundles> mBundleManagers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_mBundleManagers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IResourceManager_Bundles>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_mBundleManagers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C9 RID: 6601
		// (get) Token: 0x0600468B RID: 18059 RVA: 0x001073B0 File Offset: 0x001055B0
		// (set) Token: 0x0600468C RID: 18060 RVA: 0x00029EC3 File Offset: 0x000280C3
		public unsafe Il2CppReferenceArray<global::UnityEngine.Object> Assets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_Assets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<global::UnityEngine.Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_Assets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019CA RID: 6602
		// (get) Token: 0x0600468D RID: 18061 RVA: 0x001073E0 File Offset: 0x001055E0
		// (set) Token: 0x0600468E RID: 18062 RVA: 0x00029EE2 File Offset: 0x000280E2
		public unsafe Dictionary<string, global::UnityEngine.Object> mResourcesCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_mResourcesCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, global::UnityEngine.Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_mResourcesCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002C16 RID: 11286
		private static readonly IntPtr NativeFieldInfoPtr_mInstance;

		// Token: 0x04002C17 RID: 11287
		private static readonly IntPtr NativeFieldInfoPtr_mBundleManagers;

		// Token: 0x04002C18 RID: 11288
		private static readonly IntPtr NativeFieldInfoPtr_Assets;

		// Token: 0x04002C19 RID: 11289
		private static readonly IntPtr NativeFieldInfoPtr_mResourcesCache;

		// Token: 0x04002C1A RID: 11290
		private static readonly IntPtr NativeMethodInfoPtr_get_pInstance_Public_Static_get_ResourceManager_0;

		// Token: 0x04002C1B RID: 11291
		private static readonly IntPtr NativeMethodInfoPtr_MyOnLevelWasLoaded_Public_Static_Void_Scene_LoadSceneMode_0;

		// Token: 0x04002C1C RID: 11292
		private static readonly IntPtr NativeMethodInfoPtr_GetAsset_Public_T_String_0;

		// Token: 0x04002C1D RID: 11293
		private static readonly IntPtr NativeMethodInfoPtr_FindAsset_Private_Object_String_0;

		// Token: 0x04002C1E RID: 11294
		private static readonly IntPtr NativeMethodInfoPtr_HasAsset_Public_Boolean_Object_0;

		// Token: 0x04002C1F RID: 11295
		private static readonly IntPtr NativeMethodInfoPtr_LoadFromResources_Public_T_String_0;

		// Token: 0x04002C20 RID: 11296
		private static readonly IntPtr NativeMethodInfoPtr_LoadFromBundle_Public_T_String_0;

		// Token: 0x04002C21 RID: 11297
		private static readonly IntPtr NativeMethodInfoPtr_CleanResourceCache_Public_Void_Boolean_0;

		// Token: 0x04002C22 RID: 11298
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003DC RID: 988
		private sealed class MethodInfoStoreGeneric_GetAsset_Public_T_String_0<T>
		{
			// Token: 0x04003C2A RID: 15402
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ResourceManager.NativeMethodInfoPtr_GetAsset_Public_T_String_0, Il2CppClassPointerStore<ResourceManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003DD RID: 989
		private sealed class MethodInfoStoreGeneric_LoadFromResources_Public_T_String_0<T>
		{
			// Token: 0x04003C2B RID: 15403
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ResourceManager.NativeMethodInfoPtr_LoadFromResources_Public_T_String_0, Il2CppClassPointerStore<ResourceManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003DE RID: 990
		private sealed class MethodInfoStoreGeneric_LoadFromBundle_Public_T_String_0<T>
		{
			// Token: 0x04003C2C RID: 15404
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ResourceManager.NativeMethodInfoPtr_LoadFromBundle_Public_T_String_0, Il2CppClassPointerStore<ResourceManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
