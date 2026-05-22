using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.SceneManagement
{
	// Token: 0x0200013C RID: 316
	public static class SceneManagerAPIInternal : Object
	{
		// Token: 0x060018FB RID: 6395 RVA: 0x000609B0 File Offset: 0x0005EBB0
		// Note: this type is marked as 'beforefieldinit'.
		static SceneManagerAPIInternal()
		{
			Il2CppClassPointerStore<SceneManagerAPIInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.SceneManagement", "SceneManagerAPIInternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManagerAPIInternal>.NativeClassPtr);
			SceneManagerAPIInternal.NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Public_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPIInternal>.NativeClassPtr, 100665609);
			SceneManagerAPIInternal.NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Injected_Private_Static_AsyncOperation_String_Int32_byref_LoadSceneParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPIInternal>.NativeClassPtr, 100665610);
			SceneManagerAPIInternal.GetNumScenesInBuildSettingsDelegateField = IL2CPP.ResolveICall<SceneManagerAPIInternal.GetNumScenesInBuildSettingsDelegate>("UnityEngine.SceneManagement.SceneManagerAPIInternal::GetNumScenesInBuildSettings");
			SceneManagerAPIInternal.UnloadSceneNameIndexInternalDelegateField = IL2CPP.ResolveICall<SceneManagerAPIInternal.UnloadSceneNameIndexInternalDelegate>("UnityEngine.SceneManagement.SceneManagerAPIInternal::UnloadSceneNameIndexInternal");
			SceneManagerAPIInternal.GetSceneByBuildIndex_InjectedDelegateField = IL2CPP.ResolveICall<SceneManagerAPIInternal.GetSceneByBuildIndex_InjectedDelegate>("UnityEngine.SceneManagement.SceneManagerAPIInternal::GetSceneByBuildIndex_Injected");
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x00060A38 File Offset: 0x0005EC38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501722, XrefRangeEnd = 501724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManagerAPIInternal.NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Public_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x00060AA8 File Offset: 0x0005ECA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501724, XrefRangeEnd = 501728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation LoadSceneAsyncNameIndexInternal_Injected(string sceneName, int sceneBuildIndex, ref LoadSceneParameters parameters, bool mustCompleteNextFrame)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sceneBuildIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &parameters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mustCompleteNextFrame;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManagerAPIInternal.NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Injected_Private_Static_AsyncOperation_String_Int32_byref_LoadSceneParameters_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x0000D1FD File Offset: 0x0000B3FD
		public SceneManagerAPIInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x0000D206 File Offset: 0x0000B406
		public static int GetNumScenesInBuildSettings()
		{
			return SceneManagerAPIInternal.GetNumScenesInBuildSettingsDelegateField();
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x00060B18 File Offset: 0x0005ED18
		public static Scene GetSceneByBuildIndex(int buildIndex)
		{
			Scene scene;
			SceneManagerAPIInternal.GetSceneByBuildIndex_Injected(buildIndex, out scene);
			return scene;
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x00060B30 File Offset: 0x0005ED30
		public static AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess)
		{
			IntPtr intPtr = SceneManagerAPIInternal.UnloadSceneNameIndexInternalDelegateField(IL2CPP.ManagedStringToIl2Cpp(sceneName), sceneBuildIndex, immediately, options, out outSuccess);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x0000D212 File Offset: 0x0000B412
		public static void GetSceneByBuildIndex_Injected(int buildIndex, out Scene ret)
		{
			SceneManagerAPIInternal.GetSceneByBuildIndex_InjectedDelegateField(buildIndex, out ret);
		}

		// Token: 0x0400133F RID: 4927
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Public_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0;

		// Token: 0x04001340 RID: 4928
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Injected_Private_Static_AsyncOperation_String_Int32_byref_LoadSceneParameters_Boolean_0;

		// Token: 0x04001341 RID: 4929
		private static readonly SceneManagerAPIInternal.GetNumScenesInBuildSettingsDelegate GetNumScenesInBuildSettingsDelegateField;

		// Token: 0x04001342 RID: 4930
		private static readonly SceneManagerAPIInternal.UnloadSceneNameIndexInternalDelegate UnloadSceneNameIndexInternalDelegateField;

		// Token: 0x04001343 RID: 4931
		private static readonly SceneManagerAPIInternal.GetSceneByBuildIndex_InjectedDelegate GetSceneByBuildIndex_InjectedDelegateField;

		// Token: 0x020008AF RID: 2223
		// (Invoke) Token: 0x06002FD7 RID: 12247
		private delegate int GetNumScenesInBuildSettingsDelegate();

		// Token: 0x020008B0 RID: 2224
		// (Invoke) Token: 0x06002FD9 RID: 12249
		private delegate IntPtr UnloadSceneNameIndexInternalDelegate(IntPtr sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, [Out] IntPtr outSuccess);

		// Token: 0x020008B1 RID: 2225
		// (Invoke) Token: 0x06002FDB RID: 12251
		private delegate void GetSceneByBuildIndex_InjectedDelegate(int buildIndex, [Out] IntPtr ret);
	}
}
