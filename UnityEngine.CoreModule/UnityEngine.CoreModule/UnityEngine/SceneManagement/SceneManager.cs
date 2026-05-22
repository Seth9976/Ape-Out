using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Events;

namespace UnityEngine.SceneManagement
{
	// Token: 0x0200013E RID: 318
	public class SceneManager : Object
	{
		// Token: 0x06001912 RID: 6418 RVA: 0x00060DF4 File Offset: 0x0005EFF4
		// Note: this type is marked as 'beforefieldinit'.
		static SceneManager()
		{
			Il2CppClassPointerStore<SceneManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.SceneManagement", "SceneManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager>.NativeClassPtr);
			SceneManager.NativeFieldInfoPtr_s_AllowLoadScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "s_AllowLoadScene");
			SceneManager.NativeFieldInfoPtr_sceneLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "sceneLoaded");
			SceneManager.NativeFieldInfoPtr_sceneUnloaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "sceneUnloaded");
			SceneManager.NativeFieldInfoPtr_activeSceneChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "activeSceneChanged");
			SceneManager.NativeMethodInfoPtr_get_sceneCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665617);
			SceneManager.NativeMethodInfoPtr_GetActiveScene_Public_Static_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665618);
			SceneManager.NativeMethodInfoPtr_GetSceneAt_Public_Static_Scene_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665619);
			SceneManager.NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Private_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665620);
			SceneManager.NativeMethodInfoPtr_LoadFirstScene_Internal_Internal_Static_AsyncOperation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665621);
			SceneManager.NativeMethodInfoPtr_add_sceneLoaded_Public_Static_add_Void_UnityAction_2_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665622);
			SceneManager.NativeMethodInfoPtr_remove_sceneLoaded_Public_Static_rem_Void_UnityAction_2_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665623);
			SceneManager.NativeMethodInfoPtr_LoadScene_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665624);
			SceneManager.NativeMethodInfoPtr_LoadScene_Public_Static_Scene_String_LoadSceneParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665625);
			SceneManager.NativeMethodInfoPtr_LoadScene_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665626);
			SceneManager.NativeMethodInfoPtr_LoadScene_Public_Static_Scene_Int32_LoadSceneParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665627);
			SceneManager.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665628);
			SceneManager.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_Int32_LoadSceneParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665629);
			SceneManager.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_String_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665630);
			SceneManager.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665631);
			SceneManager.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_String_LoadSceneParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665632);
			SceneManager.NativeMethodInfoPtr_Internal_SceneLoaded_Private_Static_Void_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665633);
			SceneManager.NativeMethodInfoPtr_Internal_SceneUnloaded_Private_Static_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665634);
			SceneManager.NativeMethodInfoPtr_Internal_ActiveSceneChanged_Private_Static_Void_Scene_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665635);
			SceneManager.NativeMethodInfoPtr_GetActiveScene_Injected_Private_Static_Void_byref_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665637);
			SceneManager.NativeMethodInfoPtr_GetSceneAt_Injected_Private_Static_Void_Int32_byref_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665638);
			SceneManager.SetActiveScene_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.SetActiveScene_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::SetActiveScene_Injected");
			SceneManager.GetSceneByPath_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.GetSceneByPath_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::GetSceneByPath_Injected");
			SceneManager.GetSceneByName_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.GetSceneByName_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::GetSceneByName_Injected");
			SceneManager.CreateScene_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.CreateScene_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::CreateScene_Injected");
			SceneManager.UnloadSceneInternal_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.UnloadSceneInternal_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::UnloadSceneInternal_Injected");
			SceneManager.UnloadSceneAsyncInternal_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.UnloadSceneAsyncInternal_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::UnloadSceneAsyncInternal_Injected");
			SceneManager.MergeScenes_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.MergeScenes_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::MergeScenes_Injected");
			SceneManager.MoveGameObjectToScene_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.MoveGameObjectToScene_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::MoveGameObjectToScene_Injected");
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06001913 RID: 6419 RVA: 0x00061090 File Offset: 0x0005F290
		public unsafe static int sceneCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501746, XrefRangeEnd = 501750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_get_sceneCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x000610C0 File Offset: 0x0005F2C0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 501755, RefRangeEnd = 501759, XrefRangeStart = 501750, XrefRangeEnd = 501755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Scene GetActiveScene()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_GetActiveScene_Public_Static_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x000610F0 File Offset: 0x0005F2F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 501764, RefRangeEnd = 501768, XrefRangeStart = 501759, XrefRangeEnd = 501764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Scene GetSceneAt(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_GetSceneAt_Public_Static_Scene_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x00061130 File Offset: 0x0005F330
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 501777, RefRangeEnd = 501784, XrefRangeStart = 501768, XrefRangeEnd = 501777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sceneBuildIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parameters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mustCompleteNextFrame;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Private_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x000611A0 File Offset: 0x0005F3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501784, XrefRangeEnd = 501789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation LoadFirstScene_Internal(bool async)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref async;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadFirstScene_Internal_Internal_Static_AsyncOperation_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
			}
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x000611E0 File Offset: 0x0005F3E0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 501799, RefRangeEnd = 501807, XrefRangeStart = 501789, XrefRangeEnd = 501799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_sceneLoaded(UnityEngine.Events.UnityAction<Scene, LoadSceneMode> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_add_sceneLoaded_Public_Static_add_Void_UnityAction_2_Scene_LoadSceneMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x00061218 File Offset: 0x0005F418
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 501817, RefRangeEnd = 501819, XrefRangeStart = 501807, XrefRangeEnd = 501817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_sceneLoaded(UnityEngine.Events.UnityAction<Scene, LoadSceneMode> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_remove_sceneLoaded_Public_Static_rem_Void_UnityAction_2_Scene_LoadSceneMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x00061250 File Offset: 0x0005F450
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 501830, RefRangeEnd = 501833, XrefRangeStart = 501819, XrefRangeEnd = 501830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadScene(string sceneName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadScene_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x00061288 File Offset: 0x0005F488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501833, XrefRangeEnd = 501842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Scene LoadScene(string sceneName, LoadSceneParameters parameters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadScene_Public_Static_Scene_String_LoadSceneParameters_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x000612D8 File Offset: 0x0005F4D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 501853, RefRangeEnd = 501857, XrefRangeStart = 501842, XrefRangeEnd = 501853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadScene(int sceneBuildIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sceneBuildIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadScene_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x0006130C File Offset: 0x0005F50C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501857, XrefRangeEnd = 501866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Scene LoadScene(int sceneBuildIndex, LoadSceneParameters parameters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sceneBuildIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadScene_Public_Static_Scene_Int32_LoadSceneParameters_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x00061358 File Offset: 0x0005F558
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 501874, RefRangeEnd = 501877, XrefRangeStart = 501866, XrefRangeEnd = 501874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation LoadSceneAsync(int sceneBuildIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sceneBuildIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
			}
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x00061398 File Offset: 0x0005F598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501877, XrefRangeEnd = 501881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation LoadSceneAsync(int sceneBuildIndex, LoadSceneParameters parameters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sceneBuildIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_Int32_LoadSceneParameters_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x000613E8 File Offset: 0x0005F5E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501881, XrefRangeEnd = 501885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode mode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_String_LoadSceneMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x0006143C File Offset: 0x0005F63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501885, XrefRangeEnd = 501889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation LoadSceneAsync(string sceneName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
			}
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x00061480 File Offset: 0x0005F680
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 501893, RefRangeEnd = 501897, XrefRangeStart = 501889, XrefRangeEnd = 501893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_String_LoadSceneParameters_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x000614D4 File Offset: 0x0005F6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501897, XrefRangeEnd = 501906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Internal_SceneLoaded_Private_Static_Void_Scene_LoadSceneMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x00061514 File Offset: 0x0005F714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501906, XrefRangeEnd = 501915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_SceneUnloaded(Scene scene)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scene;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Internal_SceneUnloaded_Private_Static_Void_Scene_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x00061548 File Offset: 0x0005F748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501915, XrefRangeEnd = 501924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref previousActiveScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newActiveScene;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Internal_ActiveSceneChanged_Private_Static_Void_Scene_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x00061588 File Offset: 0x0005F788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501924, XrefRangeEnd = 501928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetActiveScene_Injected(out Scene ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_GetActiveScene_Injected_Private_Static_Void_byref_Scene_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x000615BC File Offset: 0x0005F7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501928, XrefRangeEnd = 501932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSceneAt_Injected(int index, out Scene ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_GetSceneAt_Injected_Private_Static_Void_Int32_byref_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001928 RID: 6440 RVA: 0x0000D272 File Offset: 0x0000B472
		public SceneManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06001929 RID: 6441 RVA: 0x000615FC File Offset: 0x0005F7FC
		// (set) Token: 0x0600192A RID: 6442 RVA: 0x0000D27B File Offset: 0x0000B47B
		public unsafe static bool s_AllowLoadScene
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_s_AllowLoadScene, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_s_AllowLoadScene, (void*)(&value));
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x0600192B RID: 6443 RVA: 0x00061618 File Offset: 0x0005F818
		// (set) Token: 0x0600192C RID: 6444 RVA: 0x0000D289 File Offset: 0x0000B489
		public unsafe static UnityEngine.Events.UnityAction<Scene, LoadSceneMode> sceneLoaded
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_sceneLoaded, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.Events.UnityAction<Scene, LoadSceneMode>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_sceneLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x0600192D RID: 6445 RVA: 0x00061640 File Offset: 0x0005F840
		// (set) Token: 0x0600192E RID: 6446 RVA: 0x0000D29B File Offset: 0x0000B49B
		public unsafe static UnityEngine.Events.UnityAction<Scene> sceneUnloaded
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_sceneUnloaded, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.Events.UnityAction<Scene>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_sceneUnloaded, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x0600192F RID: 6447 RVA: 0x00061668 File Offset: 0x0005F868
		// (set) Token: 0x06001930 RID: 6448 RVA: 0x0000D2AD File Offset: 0x0000B4AD
		public unsafe static UnityEngine.Events.UnityAction<Scene, Scene> activeSceneChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_activeSceneChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.Events.UnityAction<Scene, Scene>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_activeSceneChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06001931 RID: 6449 RVA: 0x00061690 File Offset: 0x0005F890
		public static int sceneCountInBuildSettings
		{
			get
			{
				return SceneManagerAPI.ActiveAPI.GetNumScenesInBuildSettings();
			}
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x0000D2BF File Offset: 0x0000B4BF
		public static bool SetActiveScene(Scene scene)
		{
			return SceneManager.SetActiveScene_Injected(ref scene);
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x000616AC File Offset: 0x0005F8AC
		public static Scene GetSceneByPath(string scenePath)
		{
			Scene scene;
			SceneManager.GetSceneByPath_Injected(scenePath, out scene);
			return scene;
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x000616C4 File Offset: 0x0005F8C4
		public static Scene GetSceneByName(string name)
		{
			Scene scene;
			SceneManager.GetSceneByName_Injected(name, out scene);
			return scene;
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x000616DC File Offset: 0x0005F8DC
		public static Scene GetSceneByBuildIndex(int buildIndex)
		{
			return SceneManagerAPI.ActiveAPI.GetSceneByBuildIndex(buildIndex);
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x000616FC File Offset: 0x0005F8FC
		public static Scene CreateScene(string sceneName, CreateSceneParameters parameters)
		{
			Scene scene;
			SceneManager.CreateScene_Injected(sceneName, ref parameters, out scene);
			return scene;
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x0000D2C8 File Offset: 0x0000B4C8
		public static bool UnloadSceneInternal(Scene scene, UnloadSceneOptions options)
		{
			return SceneManager.UnloadSceneInternal_Injected(ref scene, options);
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x0000D2D2 File Offset: 0x0000B4D2
		public static AsyncOperation UnloadSceneAsyncInternal(Scene scene, UnloadSceneOptions options)
		{
			return SceneManager.UnloadSceneAsyncInternal_Injected(ref scene, options);
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x00061714 File Offset: 0x0005F914
		public static AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess)
		{
			bool flag = !SceneManager.s_AllowLoadScene;
			AsyncOperation asyncOperation;
			if (flag)
			{
				outSuccess = false;
				asyncOperation = null;
			}
			else
			{
				asyncOperation = SceneManagerAPI.ActiveAPI.UnloadSceneAsyncByNameOrIndex(sceneName, sceneBuildIndex, immediately, options, out outSuccess);
			}
			return asyncOperation;
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x0000D2DC File Offset: 0x0000B4DC
		public static void MergeScenes(Scene sourceScene, Scene destinationScene)
		{
			SceneManager.MergeScenes_Injected(ref sourceScene, ref destinationScene);
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x0000D2E7 File Offset: 0x0000B4E7
		public static void MoveGameObjectToScene(GameObject go, Scene scene)
		{
			SceneManager.MoveGameObjectToScene_Injected(go, ref scene);
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x0000D2F1 File Offset: 0x0000B4F1
		public static void add_sceneUnloaded(UnityEngine.Events.UnityAction<Scene> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x0000D2FE File Offset: 0x0000B4FE
		public static void remove_sceneUnloaded(UnityEngine.Events.UnityAction<Scene> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x0000D30B File Offset: 0x0000B50B
		public static void add_activeSceneChanged(UnityEngine.Events.UnityAction<Scene, Scene> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x0000D318 File Offset: 0x0000B518
		public static void remove_activeSceneChanged(UnityEngine.Events.UnityAction<Scene, Scene> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x0000D325 File Offset: 0x0000B525
		public static Il2CppStructArray<Scene> GetAllScenes()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x0006174C File Offset: 0x0005F94C
		public static Scene CreateScene(string sceneName)
		{
			CreateSceneParameters createSceneParameters = new CreateSceneParameters(LocalPhysicsMode.None);
			return SceneManager.CreateScene(sceneName, createSceneParameters);
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x00061770 File Offset: 0x0005F970
		public static void LoadScene(string sceneName, LoadSceneMode mode)
		{
			LoadSceneParameters loadSceneParameters = new LoadSceneParameters(mode);
			SceneManager.LoadScene(sceneName, loadSceneParameters);
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x00061790 File Offset: 0x0005F990
		public static void LoadScene(int sceneBuildIndex, LoadSceneMode mode)
		{
			LoadSceneParameters loadSceneParameters = new LoadSceneParameters(mode);
			SceneManager.LoadScene(sceneBuildIndex, loadSceneParameters);
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x000617B0 File Offset: 0x0005F9B0
		public static AsyncOperation LoadSceneAsync(int sceneBuildIndex, LoadSceneMode mode)
		{
			LoadSceneParameters loadSceneParameters = new LoadSceneParameters(mode);
			return SceneManager.LoadSceneAsync(sceneBuildIndex, loadSceneParameters);
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x000617D4 File Offset: 0x0005F9D4
		public static bool UnloadScene(Scene scene)
		{
			return SceneManager.UnloadSceneInternal(scene, UnloadSceneOptions.None);
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x000617F0 File Offset: 0x0005F9F0
		public static bool UnloadScene(int sceneBuildIndex)
		{
			bool flag;
			SceneManager.UnloadSceneNameIndexInternal("", sceneBuildIndex, true, UnloadSceneOptions.None, out flag);
			return flag;
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x00061814 File Offset: 0x0005FA14
		public static bool UnloadScene(string sceneName)
		{
			bool flag;
			SceneManager.UnloadSceneNameIndexInternal(sceneName, -1, true, UnloadSceneOptions.None, out flag);
			return flag;
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x00061834 File Offset: 0x0005FA34
		public static AsyncOperation UnloadSceneAsync(int sceneBuildIndex)
		{
			bool flag;
			return SceneManager.UnloadSceneNameIndexInternal("", sceneBuildIndex, false, UnloadSceneOptions.None, out flag);
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x00061858 File Offset: 0x0005FA58
		public static AsyncOperation UnloadSceneAsync(string sceneName)
		{
			bool flag;
			return SceneManager.UnloadSceneNameIndexInternal(sceneName, -1, false, UnloadSceneOptions.None, out flag);
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x00061878 File Offset: 0x0005FA78
		public static AsyncOperation UnloadSceneAsync(Scene scene)
		{
			return SceneManager.UnloadSceneAsyncInternal(scene, UnloadSceneOptions.None);
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x00061894 File Offset: 0x0005FA94
		public static AsyncOperation UnloadSceneAsync(int sceneBuildIndex, UnloadSceneOptions options)
		{
			bool flag;
			return SceneManager.UnloadSceneNameIndexInternal("", sceneBuildIndex, false, options, out flag);
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x000618B8 File Offset: 0x0005FAB8
		public static AsyncOperation UnloadSceneAsync(string sceneName, UnloadSceneOptions options)
		{
			bool flag;
			return SceneManager.UnloadSceneNameIndexInternal(sceneName, -1, false, options, out flag);
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x000618D8 File Offset: 0x0005FAD8
		public static AsyncOperation UnloadSceneAsync(Scene scene, UnloadSceneOptions options)
		{
			return SceneManager.UnloadSceneAsyncInternal(scene, options);
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x0000D332 File Offset: 0x0000B532
		public static bool SetActiveScene_Injected(ref Scene scene)
		{
			return SceneManager.SetActiveScene_InjectedDelegateField(ref scene);
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x0000D33F File Offset: 0x0000B53F
		public static void GetSceneByPath_Injected(string scenePath, out Scene ret)
		{
			SceneManager.GetSceneByPath_InjectedDelegateField(IL2CPP.ManagedStringToIl2Cpp(scenePath), out ret);
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x0000D352 File Offset: 0x0000B552
		public static void GetSceneByName_Injected(string name, out Scene ret)
		{
			SceneManager.GetSceneByName_InjectedDelegateField(IL2CPP.ManagedStringToIl2Cpp(name), out ret);
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x0000D365 File Offset: 0x0000B565
		public static void CreateScene_Injected(string sceneName, ref CreateSceneParameters parameters, out Scene ret)
		{
			SceneManager.CreateScene_InjectedDelegateField(IL2CPP.ManagedStringToIl2Cpp(sceneName), ref parameters, out ret);
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x0000D379 File Offset: 0x0000B579
		public static bool UnloadSceneInternal_Injected(ref Scene scene, UnloadSceneOptions options)
		{
			return SceneManager.UnloadSceneInternal_InjectedDelegateField(ref scene, options);
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x000618F4 File Offset: 0x0005FAF4
		public static AsyncOperation UnloadSceneAsyncInternal_Injected(ref Scene scene, UnloadSceneOptions options)
		{
			IntPtr intPtr = SceneManager.UnloadSceneAsyncInternal_InjectedDelegateField(ref scene, options);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x0000D387 File Offset: 0x0000B587
		public static void MergeScenes_Injected(ref Scene sourceScene, ref Scene destinationScene)
		{
			SceneManager.MergeScenes_InjectedDelegateField(ref sourceScene, ref destinationScene);
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x0000D395 File Offset: 0x0000B595
		public static void MoveGameObjectToScene_Injected(GameObject go, ref Scene scene)
		{
			SceneManager.MoveGameObjectToScene_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(go), ref scene);
		}

		// Token: 0x0400134B RID: 4939
		private static readonly IntPtr NativeFieldInfoPtr_s_AllowLoadScene;

		// Token: 0x0400134C RID: 4940
		private static readonly IntPtr NativeFieldInfoPtr_sceneLoaded;

		// Token: 0x0400134D RID: 4941
		private static readonly IntPtr NativeFieldInfoPtr_sceneUnloaded;

		// Token: 0x0400134E RID: 4942
		private static readonly IntPtr NativeFieldInfoPtr_activeSceneChanged;

		// Token: 0x0400134F RID: 4943
		private static readonly IntPtr NativeMethodInfoPtr_get_sceneCount_Public_Static_get_Int32_0;

		// Token: 0x04001350 RID: 4944
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveScene_Public_Static_Scene_0;

		// Token: 0x04001351 RID: 4945
		private static readonly IntPtr NativeMethodInfoPtr_GetSceneAt_Public_Static_Scene_Int32_0;

		// Token: 0x04001352 RID: 4946
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Private_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0;

		// Token: 0x04001353 RID: 4947
		private static readonly IntPtr NativeMethodInfoPtr_LoadFirstScene_Internal_Internal_Static_AsyncOperation_Boolean_0;

		// Token: 0x04001354 RID: 4948
		private static readonly IntPtr NativeMethodInfoPtr_add_sceneLoaded_Public_Static_add_Void_UnityAction_2_Scene_LoadSceneMode_0;

		// Token: 0x04001355 RID: 4949
		private static readonly IntPtr NativeMethodInfoPtr_remove_sceneLoaded_Public_Static_rem_Void_UnityAction_2_Scene_LoadSceneMode_0;

		// Token: 0x04001356 RID: 4950
		private static readonly IntPtr NativeMethodInfoPtr_LoadScene_Public_Static_Void_String_0;

		// Token: 0x04001357 RID: 4951
		private static readonly IntPtr NativeMethodInfoPtr_LoadScene_Public_Static_Scene_String_LoadSceneParameters_0;

		// Token: 0x04001358 RID: 4952
		private static readonly IntPtr NativeMethodInfoPtr_LoadScene_Public_Static_Void_Int32_0;

		// Token: 0x04001359 RID: 4953
		private static readonly IntPtr NativeMethodInfoPtr_LoadScene_Public_Static_Scene_Int32_LoadSceneParameters_0;

		// Token: 0x0400135A RID: 4954
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_Int32_0;

		// Token: 0x0400135B RID: 4955
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_Int32_LoadSceneParameters_0;

		// Token: 0x0400135C RID: 4956
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_String_LoadSceneMode_0;

		// Token: 0x0400135D RID: 4957
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_String_0;

		// Token: 0x0400135E RID: 4958
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_String_LoadSceneParameters_0;

		// Token: 0x0400135F RID: 4959
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SceneLoaded_Private_Static_Void_Scene_LoadSceneMode_0;

		// Token: 0x04001360 RID: 4960
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SceneUnloaded_Private_Static_Void_Scene_0;

		// Token: 0x04001361 RID: 4961
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ActiveSceneChanged_Private_Static_Void_Scene_Scene_0;

		// Token: 0x04001362 RID: 4962
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveScene_Injected_Private_Static_Void_byref_Scene_0;

		// Token: 0x04001363 RID: 4963
		private static readonly IntPtr NativeMethodInfoPtr_GetSceneAt_Injected_Private_Static_Void_Int32_byref_Scene_0;

		// Token: 0x04001364 RID: 4964
		private static readonly SceneManager.SetActiveScene_InjectedDelegate SetActiveScene_InjectedDelegateField;

		// Token: 0x04001365 RID: 4965
		private static readonly SceneManager.GetSceneByPath_InjectedDelegate GetSceneByPath_InjectedDelegateField;

		// Token: 0x04001366 RID: 4966
		private static readonly SceneManager.GetSceneByName_InjectedDelegate GetSceneByName_InjectedDelegateField;

		// Token: 0x04001367 RID: 4967
		private static readonly SceneManager.CreateScene_InjectedDelegate CreateScene_InjectedDelegateField;

		// Token: 0x04001368 RID: 4968
		private static readonly SceneManager.UnloadSceneInternal_InjectedDelegate UnloadSceneInternal_InjectedDelegateField;

		// Token: 0x04001369 RID: 4969
		private static readonly SceneManager.UnloadSceneAsyncInternal_InjectedDelegate UnloadSceneAsyncInternal_InjectedDelegateField;

		// Token: 0x0400136A RID: 4970
		private static readonly SceneManager.MergeScenes_InjectedDelegate MergeScenes_InjectedDelegateField;

		// Token: 0x0400136B RID: 4971
		private static readonly SceneManager.MoveGameObjectToScene_InjectedDelegate MoveGameObjectToScene_InjectedDelegateField;

		// Token: 0x020008B2 RID: 2226
		// (Invoke) Token: 0x06002FDD RID: 12253
		private delegate bool SetActiveScene_InjectedDelegate(IntPtr scene);

		// Token: 0x020008B3 RID: 2227
		// (Invoke) Token: 0x06002FDF RID: 12255
		private delegate void GetSceneByPath_InjectedDelegate(IntPtr scenePath, [Out] IntPtr ret);

		// Token: 0x020008B4 RID: 2228
		// (Invoke) Token: 0x06002FE1 RID: 12257
		private delegate void GetSceneByName_InjectedDelegate(IntPtr name, [Out] IntPtr ret);

		// Token: 0x020008B5 RID: 2229
		// (Invoke) Token: 0x06002FE3 RID: 12259
		private delegate void CreateScene_InjectedDelegate(IntPtr sceneName, IntPtr parameters, [Out] IntPtr ret);

		// Token: 0x020008B6 RID: 2230
		// (Invoke) Token: 0x06002FE5 RID: 12261
		private delegate bool UnloadSceneInternal_InjectedDelegate(IntPtr scene, UnloadSceneOptions options);

		// Token: 0x020008B7 RID: 2231
		// (Invoke) Token: 0x06002FE7 RID: 12263
		private delegate IntPtr UnloadSceneAsyncInternal_InjectedDelegate(IntPtr scene, UnloadSceneOptions options);

		// Token: 0x020008B8 RID: 2232
		// (Invoke) Token: 0x06002FE9 RID: 12265
		private delegate void MergeScenes_InjectedDelegate(IntPtr sourceScene, IntPtr destinationScene);

		// Token: 0x020008B9 RID: 2233
		// (Invoke) Token: 0x06002FEB RID: 12267
		private delegate void MoveGameObjectToScene_InjectedDelegate(IntPtr go, IntPtr scene);
	}
}
