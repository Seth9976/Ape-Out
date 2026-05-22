using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;

namespace UnityEngine
{
	// Token: 0x02000242 RID: 578
	public static class HotReloadDeserializer
	{
		// Token: 0x060021A3 RID: 8611 RVA: 0x00011D46 File Offset: 0x0000FF46
		public static void PrepareHotReload()
		{
			HotReloadDeserializer.PrepareHotReloadDelegateField();
		}

		// Token: 0x060021A4 RID: 8612 RVA: 0x00011D52 File Offset: 0x0000FF52
		public static void FinishHotReload(Il2CppReferenceArray<Type> typesToReset)
		{
			HotReloadDeserializer.FinishHotReloadDelegateField(IL2CPP.Il2CppObjectBaseToPtr(typesToReset));
		}

		// Token: 0x060021A5 RID: 8613 RVA: 0x00076CCC File Offset: 0x00074ECC
		public static Object CreateEmptyAsset(Type type)
		{
			IntPtr intPtr = HotReloadDeserializer.CreateEmptyAssetDelegateField(IL2CPP.Il2CppObjectBaseToPtr(type));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x060021A6 RID: 8614 RVA: 0x00011D64 File Offset: 0x0000FF64
		public static void DeserializeAsset(Object asset, Il2CppStructArray<byte> data)
		{
			HotReloadDeserializer.DeserializeAssetDelegateField(IL2CPP.Il2CppObjectBaseToPtr(asset), IL2CPP.Il2CppObjectBaseToPtr(data));
		}

		// Token: 0x060021A7 RID: 8615 RVA: 0x00011D7C File Offset: 0x0000FF7C
		public static void RemapInstanceIds(Object editorAsset, Il2CppStructArray<int> editorToPlayerInstanceIdMapKeys, Il2CppStructArray<int> editorToPlayerInstanceIdMapValues)
		{
			HotReloadDeserializer.RemapInstanceIdsDelegateField(IL2CPP.Il2CppObjectBaseToPtr(editorAsset), IL2CPP.Il2CppObjectBaseToPtr(editorToPlayerInstanceIdMapKeys), IL2CPP.Il2CppObjectBaseToPtr(editorToPlayerInstanceIdMapValues));
		}

		// Token: 0x060021A8 RID: 8616 RVA: 0x00011D9A File Offset: 0x0000FF9A
		public static void RemapInstanceIds(Object editorAsset, Dictionary<int, int> editorToPlayerInstanceIdMap)
		{
			HotReloadDeserializer.RemapInstanceIds(editorAsset, editorToPlayerInstanceIdMap.Keys.ToArray<int>(), editorToPlayerInstanceIdMap.Values.ToArray<int>());
		}

		// Token: 0x060021A9 RID: 8617 RVA: 0x00011DBA File Offset: 0x0000FFBA
		public static void FinalizeAssetCreation(Object asset)
		{
			HotReloadDeserializer.FinalizeAssetCreationDelegateField(IL2CPP.Il2CppObjectBaseToPtr(asset));
		}

		// Token: 0x060021AA RID: 8618 RVA: 0x00076CF8 File Offset: 0x00074EF8
		public static Il2CppReferenceArray<Object> GetDependencies(Object asset)
		{
			IntPtr intPtr = HotReloadDeserializer.GetDependenciesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(asset));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
		}

		// Token: 0x060021AB RID: 8619 RVA: 0x00076D24 File Offset: 0x00074F24
		public static Il2CppStructArray<int> GetNullDependencies(Object asset)
		{
			IntPtr intPtr = HotReloadDeserializer.GetNullDependenciesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(asset));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}

		// Token: 0x04001BBB RID: 7099
		private static readonly HotReloadDeserializer.PrepareHotReloadDelegate PrepareHotReloadDelegateField = IL2CPP.ResolveICall<HotReloadDeserializer.PrepareHotReloadDelegate>("UnityEngine.HotReloadDeserializer::PrepareHotReload");

		// Token: 0x04001BBC RID: 7100
		private static readonly HotReloadDeserializer.FinishHotReloadDelegate FinishHotReloadDelegateField = IL2CPP.ResolveICall<HotReloadDeserializer.FinishHotReloadDelegate>("UnityEngine.HotReloadDeserializer::FinishHotReload");

		// Token: 0x04001BBD RID: 7101
		private static readonly HotReloadDeserializer.CreateEmptyAssetDelegate CreateEmptyAssetDelegateField = IL2CPP.ResolveICall<HotReloadDeserializer.CreateEmptyAssetDelegate>("UnityEngine.HotReloadDeserializer::CreateEmptyAsset");

		// Token: 0x04001BBE RID: 7102
		private static readonly HotReloadDeserializer.DeserializeAssetDelegate DeserializeAssetDelegateField = IL2CPP.ResolveICall<HotReloadDeserializer.DeserializeAssetDelegate>("UnityEngine.HotReloadDeserializer::DeserializeAsset");

		// Token: 0x04001BBF RID: 7103
		private static readonly HotReloadDeserializer.RemapInstanceIdsDelegate RemapInstanceIdsDelegateField = IL2CPP.ResolveICall<HotReloadDeserializer.RemapInstanceIdsDelegate>("UnityEngine.HotReloadDeserializer::RemapInstanceIds");

		// Token: 0x04001BC0 RID: 7104
		private static readonly HotReloadDeserializer.FinalizeAssetCreationDelegate FinalizeAssetCreationDelegateField = IL2CPP.ResolveICall<HotReloadDeserializer.FinalizeAssetCreationDelegate>("UnityEngine.HotReloadDeserializer::FinalizeAssetCreation");

		// Token: 0x04001BC1 RID: 7105
		private static readonly HotReloadDeserializer.GetDependenciesDelegate GetDependenciesDelegateField = IL2CPP.ResolveICall<HotReloadDeserializer.GetDependenciesDelegate>("UnityEngine.HotReloadDeserializer::GetDependencies");

		// Token: 0x04001BC2 RID: 7106
		private static readonly HotReloadDeserializer.GetNullDependenciesDelegate GetNullDependenciesDelegateField = IL2CPP.ResolveICall<HotReloadDeserializer.GetNullDependenciesDelegate>("UnityEngine.HotReloadDeserializer::GetNullDependencies");

		// Token: 0x02000B7F RID: 2943
		// (Invoke) Token: 0x0600355E RID: 13662
		private delegate void PrepareHotReloadDelegate();

		// Token: 0x02000B80 RID: 2944
		// (Invoke) Token: 0x06003560 RID: 13664
		private delegate void FinishHotReloadDelegate(IntPtr typesToReset);

		// Token: 0x02000B81 RID: 2945
		// (Invoke) Token: 0x06003562 RID: 13666
		private delegate IntPtr CreateEmptyAssetDelegate(IntPtr type);

		// Token: 0x02000B82 RID: 2946
		// (Invoke) Token: 0x06003564 RID: 13668
		private delegate void DeserializeAssetDelegate(IntPtr asset, IntPtr data);

		// Token: 0x02000B83 RID: 2947
		// (Invoke) Token: 0x06003566 RID: 13670
		private delegate void RemapInstanceIdsDelegate(IntPtr editorAsset, IntPtr editorToPlayerInstanceIdMapKeys, IntPtr editorToPlayerInstanceIdMapValues);

		// Token: 0x02000B84 RID: 2948
		// (Invoke) Token: 0x06003568 RID: 13672
		private delegate void FinalizeAssetCreationDelegate(IntPtr asset);

		// Token: 0x02000B85 RID: 2949
		// (Invoke) Token: 0x0600356A RID: 13674
		private delegate IntPtr GetDependenciesDelegate(IntPtr asset);

		// Token: 0x02000B86 RID: 2950
		// (Invoke) Token: 0x0600356C RID: 13676
		private delegate IntPtr GetNullDependenciesDelegate(IntPtr asset);
	}
}
