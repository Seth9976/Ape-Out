using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public class AssetBundle : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x0000218C File Offset: 0x0000038C
		// Note: this type is marked as 'beforefieldinit'.
		static AssetBundle()
		{
			Il2CppClassPointerStore<AssetBundle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AssetBundleModule.dll", "UnityEngine", "AssetBundle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr);
			AssetBundle.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663297);
			AssetBundle.NativeMethodInfoPtr_UnloadAllAssetBundles_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663298);
			AssetBundle.NativeMethodInfoPtr_LoadFromFile_Internal_Internal_Static_AssetBundle_String_UInt32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663299);
			AssetBundle.NativeMethodInfoPtr_LoadFromFile_Public_Static_AssetBundle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663300);
			AssetBundle.NativeMethodInfoPtr_LoadAssetAsync_Public_AssetBundleRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663301);
			AssetBundle.NativeMethodInfoPtr_LoadAssetAsync_Public_AssetBundleRequest_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663302);
			AssetBundle.NativeMethodInfoPtr_LoadAssetAsync_Internal_Private_AssetBundleRequest_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663303);
			AssetBundle.returnMainAssetDelegateField = IL2CPP.ResolveICall<AssetBundle.returnMainAssetDelegate>("UnityEngine.AssetBundle::returnMainAsset");
			AssetBundle.GetAllLoadedAssetBundles_NativeDelegateField = IL2CPP.ResolveICall<AssetBundle.GetAllLoadedAssetBundles_NativeDelegate>("UnityEngine.AssetBundle::GetAllLoadedAssetBundles_Native");
			AssetBundle.LoadFromFileAsync_InternalDelegateField = IL2CPP.ResolveICall<AssetBundle.LoadFromFileAsync_InternalDelegate>("UnityEngine.AssetBundle::LoadFromFileAsync_Internal");
			AssetBundle.LoadFromMemoryAsync_InternalDelegateField = IL2CPP.ResolveICall<AssetBundle.LoadFromMemoryAsync_InternalDelegate>("UnityEngine.AssetBundle::LoadFromMemoryAsync_Internal");
			AssetBundle.LoadFromMemory_InternalDelegateField = IL2CPP.ResolveICall<AssetBundle.LoadFromMemory_InternalDelegate>("UnityEngine.AssetBundle::LoadFromMemory_Internal");
			AssetBundle.LoadFromStreamAsyncInternalDelegateField = IL2CPP.ResolveICall<AssetBundle.LoadFromStreamAsyncInternalDelegate>("UnityEngine.AssetBundle::LoadFromStreamAsyncInternal");
			AssetBundle.LoadFromStreamInternalDelegateField = IL2CPP.ResolveICall<AssetBundle.LoadFromStreamInternalDelegate>("UnityEngine.AssetBundle::LoadFromStreamInternal");
			AssetBundle.get_isStreamedSceneAssetBundleDelegateField = IL2CPP.ResolveICall<AssetBundle.get_isStreamedSceneAssetBundleDelegate>("UnityEngine.AssetBundle::get_isStreamedSceneAssetBundle");
			AssetBundle.ContainsDelegateField = IL2CPP.ResolveICall<AssetBundle.ContainsDelegate>("UnityEngine.AssetBundle::Contains");
			AssetBundle.LoadAsset_InternalDelegateField = IL2CPP.ResolveICall<AssetBundle.LoadAsset_InternalDelegate>("UnityEngine.AssetBundle::LoadAsset_Internal");
			AssetBundle.UnloadDelegateField = IL2CPP.ResolveICall<AssetBundle.UnloadDelegate>("UnityEngine.AssetBundle::Unload");
			AssetBundle.GetAllAssetNamesDelegateField = IL2CPP.ResolveICall<AssetBundle.GetAllAssetNamesDelegate>("UnityEngine.AssetBundle::GetAllAssetNames");
			AssetBundle.GetAllScenePathsDelegateField = IL2CPP.ResolveICall<AssetBundle.GetAllScenePathsDelegate>("UnityEngine.AssetBundle::GetAllScenePaths");
			AssetBundle.LoadAssetWithSubAssets_InternalDelegateField = IL2CPP.ResolveICall<AssetBundle.LoadAssetWithSubAssets_InternalDelegate>("UnityEngine.AssetBundle::LoadAssetWithSubAssets_Internal");
			AssetBundle.LoadAssetWithSubAssetsAsync_InternalDelegateField = IL2CPP.ResolveICall<AssetBundle.LoadAssetWithSubAssetsAsync_InternalDelegate>("UnityEngine.AssetBundle::LoadAssetWithSubAssetsAsync_Internal");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000232C File Offset: 0x0000052C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484654, XrefRangeEnd = 484657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetBundle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundle.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002368 File Offset: 0x00000568
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 484661, RefRangeEnd = 484664, XrefRangeStart = 484657, XrefRangeEnd = 484661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnloadAllAssetBundles(bool unloadAllObjects)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unloadAllObjects;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundle.NativeMethodInfoPtr_UnloadAllAssetBundles_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000239C File Offset: 0x0000059C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484664, XrefRangeEnd = 484668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AssetBundle LoadFromFile_Internal(string path, uint crc, ulong offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref crc;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundle.NativeMethodInfoPtr_LoadFromFile_Internal_Internal_Static_AssetBundle_String_UInt32_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr3) : null;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000023FC File Offset: 0x000005FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484668, XrefRangeEnd = 484672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AssetBundle LoadFromFile(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundle.NativeMethodInfoPtr_LoadFromFile_Public_Static_AssetBundle_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr3) : null;
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002440 File Offset: 0x00000640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484672, XrefRangeEnd = 484699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetBundleRequest LoadAssetAsync<T>(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundle.MethodInfoStoreGeneric_LoadAssetAsync_Public_AssetBundleRequest_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002490 File Offset: 0x00000690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484699, XrefRangeEnd = 484721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetBundleRequest LoadAssetAsync(string name, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundle.NativeMethodInfoPtr_LoadAssetAsync_Public_AssetBundleRequest_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr3) : null;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000024F4 File Offset: 0x000006F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484721, XrefRangeEnd = 484725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetBundleRequest LoadAssetAsync_Internal(string name, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundle.NativeMethodInfoPtr_LoadAssetAsync_Internal_Private_AssetBundleRequest_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr3) : null;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		public AssetBundle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002558 File Offset: 0x00000758
		public Object mainAsset
		{
			get
			{
				return AssetBundle.returnMainAsset(this);
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002570 File Offset: 0x00000770
		public static Object returnMainAsset(AssetBundle bundle)
		{
			IntPtr intPtr = AssetBundle.returnMainAssetDelegateField(IL2CPP.Il2CppObjectBaseToPtr(bundle));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000259C File Offset: 0x0000079C
		public static Il2CppReferenceArray<AssetBundle> GetAllLoadedAssetBundles_Native()
		{
			IntPtr intPtr = AssetBundle.GetAllLoadedAssetBundles_NativeDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AssetBundle>>(intPtr2) : null;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000025C4 File Offset: 0x000007C4
		public static IEnumerable<AssetBundle> GetAllLoadedAssetBundles()
		{
			return AssetBundle.GetAllLoadedAssetBundles_Native();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000025DC File Offset: 0x000007DC
		public static AssetBundleCreateRequest LoadFromFileAsync_Internal(string path, uint crc, ulong offset)
		{
			IntPtr intPtr = AssetBundle.LoadFromFileAsync_InternalDelegateField(IL2CPP.ManagedStringToIl2Cpp(path), crc, offset);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleCreateRequest>(intPtr2) : null;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000260C File Offset: 0x0000080C
		public static AssetBundleCreateRequest LoadFromFileAsync(string path)
		{
			return AssetBundle.LoadFromFileAsync_Internal(path, 0U, 0UL);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002628 File Offset: 0x00000828
		public static AssetBundleCreateRequest LoadFromFileAsync(string path, uint crc)
		{
			return AssetBundle.LoadFromFileAsync_Internal(path, crc, 0UL);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002644 File Offset: 0x00000844
		public static AssetBundleCreateRequest LoadFromFileAsync(string path, uint crc, ulong offset)
		{
			return AssetBundle.LoadFromFileAsync_Internal(path, crc, offset);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002660 File Offset: 0x00000860
		public static AssetBundle LoadFromFile(string path, uint crc)
		{
			return AssetBundle.LoadFromFile_Internal(path, crc, 0UL);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000267C File Offset: 0x0000087C
		public static AssetBundle LoadFromFile(string path, uint crc, ulong offset)
		{
			return AssetBundle.LoadFromFile_Internal(path, crc, offset);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002698 File Offset: 0x00000898
		public static AssetBundleCreateRequest LoadFromMemoryAsync_Internal(Il2CppStructArray<byte> binary, uint crc)
		{
			IntPtr intPtr = AssetBundle.LoadFromMemoryAsync_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(binary), crc);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleCreateRequest>(intPtr2) : null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000026C8 File Offset: 0x000008C8
		public static AssetBundleCreateRequest LoadFromMemoryAsync(Il2CppStructArray<byte> binary)
		{
			return AssetBundle.LoadFromMemoryAsync_Internal(binary, 0U);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000026E4 File Offset: 0x000008E4
		public static AssetBundleCreateRequest LoadFromMemoryAsync(Il2CppStructArray<byte> binary, uint crc)
		{
			return AssetBundle.LoadFromMemoryAsync_Internal(binary, crc);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002700 File Offset: 0x00000900
		public static AssetBundle LoadFromMemory_Internal(Il2CppStructArray<byte> binary, uint crc)
		{
			IntPtr intPtr = AssetBundle.LoadFromMemory_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(binary), crc);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr2) : null;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002730 File Offset: 0x00000930
		public static AssetBundle LoadFromMemory(Il2CppStructArray<byte> binary)
		{
			return AssetBundle.LoadFromMemory_Internal(binary, 0U);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000274C File Offset: 0x0000094C
		public static AssetBundle LoadFromMemory(Il2CppStructArray<byte> binary, uint crc)
		{
			return AssetBundle.LoadFromMemory_Internal(binary, crc);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002768 File Offset: 0x00000968
		public static void ValidateLoadFromStream(Stream stream)
		{
			bool flag = stream == null;
			if (flag)
			{
				throw new ArgumentNullException("ManagedStream object must be non-null", "stream");
			}
			bool flag2 = !stream.CanRead;
			if (flag2)
			{
				throw new ArgumentException("ManagedStream object must be readable (stream.CanRead must return true)", "stream");
			}
			bool flag3 = !stream.CanSeek;
			if (flag3)
			{
				throw new ArgumentException("ManagedStream object must be seekable (stream.CanSeek must return true)", "stream");
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000027C8 File Offset: 0x000009C8
		public static AssetBundleCreateRequest LoadFromStreamAsync(Stream stream, uint crc, uint managedReadBufferSize)
		{
			AssetBundle.ValidateLoadFromStream(stream);
			return AssetBundle.LoadFromStreamAsyncInternal(stream, crc, managedReadBufferSize);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000027EC File Offset: 0x000009EC
		public static AssetBundleCreateRequest LoadFromStreamAsync(Stream stream, uint crc)
		{
			AssetBundle.ValidateLoadFromStream(stream);
			return AssetBundle.LoadFromStreamAsyncInternal(stream, crc, 0U);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002810 File Offset: 0x00000A10
		public static AssetBundleCreateRequest LoadFromStreamAsync(Stream stream)
		{
			AssetBundle.ValidateLoadFromStream(stream);
			return AssetBundle.LoadFromStreamAsyncInternal(stream, 0U, 0U);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002834 File Offset: 0x00000A34
		public static AssetBundle LoadFromStream(Stream stream, uint crc, uint managedReadBufferSize)
		{
			AssetBundle.ValidateLoadFromStream(stream);
			return AssetBundle.LoadFromStreamInternal(stream, crc, managedReadBufferSize);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002858 File Offset: 0x00000A58
		public static AssetBundle LoadFromStream(Stream stream, uint crc)
		{
			AssetBundle.ValidateLoadFromStream(stream);
			return AssetBundle.LoadFromStreamInternal(stream, crc, 0U);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000287C File Offset: 0x00000A7C
		public static AssetBundle LoadFromStream(Stream stream)
		{
			AssetBundle.ValidateLoadFromStream(stream);
			return AssetBundle.LoadFromStreamInternal(stream, 0U, 0U);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000028A0 File Offset: 0x00000AA0
		public static AssetBundleCreateRequest LoadFromStreamAsyncInternal(Stream stream, uint crc, uint managedReadBufferSize)
		{
			IntPtr intPtr = AssetBundle.LoadFromStreamAsyncInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(stream), crc, managedReadBufferSize);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleCreateRequest>(intPtr2) : null;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000028D0 File Offset: 0x00000AD0
		public static AssetBundle LoadFromStreamInternal(Stream stream, uint crc, uint managedReadBufferSize)
		{
			IntPtr intPtr = AssetBundle.LoadFromStreamInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(stream), crc, managedReadBufferSize);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr2) : null;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002059 File Offset: 0x00000259
		public bool isStreamedSceneAssetBundle
		{
			get
			{
				return AssetBundle.get_isStreamedSceneAssetBundleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000206B File Offset: 0x0000026B
		public bool Contains(string name)
		{
			return AssetBundle.ContainsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002900 File Offset: 0x00000B00
		public Object Load(string name)
		{
			return null;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002914 File Offset: 0x00000B14
		public Object Load<T>(string name)
		{
			return null;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002928 File Offset: 0x00000B28
		public Object Load(string name, Type type)
		{
			return null;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000293C File Offset: 0x00000B3C
		public AssetBundleRequest LoadAsync(string name, Type type)
		{
			return null;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002950 File Offset: 0x00000B50
		public Il2CppReferenceArray<Object> LoadAll(Type type)
		{
			return null;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002964 File Offset: 0x00000B64
		public Il2CppReferenceArray<Object> LoadAll()
		{
			return null;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002978 File Offset: 0x00000B78
		public Il2CppArrayBase<T> LoadAll<T>() where T : Object
		{
			return null;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000298C File Offset: 0x00000B8C
		public Object LoadAsset(string name)
		{
			return this.LoadAsset(name, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()));
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000029B0 File Offset: 0x00000BB0
		public T LoadAsset<T>(string name) where T : Object
		{
			return this.LoadAsset(name, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())).Cast<T>();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000029D8 File Offset: 0x00000BD8
		public Object LoadAsset(string name, Type type)
		{
			bool flag = name == null;
			if (flag)
			{
				throw new NullReferenceException("The input asset name cannot be null.");
			}
			bool flag2 = name.Length == 0;
			if (flag2)
			{
				throw new ArgumentException("The input asset name cannot be empty.");
			}
			bool flag3 = type == null;
			if (flag3)
			{
				throw new NullReferenceException("The input type cannot be null.");
			}
			return this.LoadAsset_Internal(name, type);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002A34 File Offset: 0x00000C34
		public Object LoadAsset_Internal(string name, Type type)
		{
			IntPtr intPtr = AssetBundle.LoadAsset_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name), IL2CPP.Il2CppObjectBaseToPtr(type));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002A6C File Offset: 0x00000C6C
		public Il2CppReferenceArray<Object> LoadAssetWithSubAssets(string name)
		{
			return this.LoadAssetWithSubAssets(name, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()));
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002083 File Offset: 0x00000283
		public static Il2CppArrayBase<T> ConvertObjects<T>(Il2CppReferenceArray<Object> rawObjects) where T : Object
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002A90 File Offset: 0x00000C90
		public Il2CppArrayBase<T> LoadAssetWithSubAssets<T>(string name) where T : Object
		{
			return AssetBundle.ConvertObjects<T>(this.LoadAssetWithSubAssets(name, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002AB8 File Offset: 0x00000CB8
		public Il2CppReferenceArray<Object> LoadAssetWithSubAssets(string name, Type type)
		{
			bool flag = name == null;
			if (flag)
			{
				throw new NullReferenceException("The input asset name cannot be null.");
			}
			bool flag2 = name.Length == 0;
			if (flag2)
			{
				throw new ArgumentException("The input asset name cannot be empty.");
			}
			bool flag3 = type == null;
			if (flag3)
			{
				throw new NullReferenceException("The input type cannot be null.");
			}
			return this.LoadAssetWithSubAssets_Internal(name, type);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002B14 File Offset: 0x00000D14
		public AssetBundleRequest LoadAssetWithSubAssetsAsync(string name)
		{
			return this.LoadAssetWithSubAssetsAsync(name, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()));
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002B38 File Offset: 0x00000D38
		public AssetBundleRequest LoadAssetWithSubAssetsAsync<T>(string name)
		{
			return this.LoadAssetWithSubAssetsAsync(name, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002B5C File Offset: 0x00000D5C
		public AssetBundleRequest LoadAssetWithSubAssetsAsync(string name, Type type)
		{
			bool flag = name == null;
			if (flag)
			{
				throw new NullReferenceException("The input asset name cannot be null.");
			}
			bool flag2 = name.Length == 0;
			if (flag2)
			{
				throw new ArgumentException("The input asset name cannot be empty.");
			}
			bool flag3 = type == null;
			if (flag3)
			{
				throw new NullReferenceException("The input type cannot be null.");
			}
			return this.LoadAssetWithSubAssetsAsync_Internal(name, type);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002BB8 File Offset: 0x00000DB8
		public Il2CppReferenceArray<Object> LoadAllAssets()
		{
			return this.LoadAllAssets(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()));
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002BDC File Offset: 0x00000DDC
		public Il2CppArrayBase<T> LoadAllAssets<T>() where T : Object
		{
			return AssetBundle.ConvertObjects<T>(this.LoadAllAssets(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002C04 File Offset: 0x00000E04
		public Il2CppReferenceArray<Object> LoadAllAssets(Type type)
		{
			bool flag = type == null;
			if (flag)
			{
				throw new NullReferenceException("The input type cannot be null.");
			}
			return this.LoadAssetWithSubAssets_Internal("", type);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002C38 File Offset: 0x00000E38
		public AssetBundleRequest LoadAllAssetsAsync()
		{
			return this.LoadAllAssetsAsync(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()));
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002C5C File Offset: 0x00000E5C
		public AssetBundleRequest LoadAllAssetsAsync<T>()
		{
			return this.LoadAllAssetsAsync(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002C80 File Offset: 0x00000E80
		public AssetBundleRequest LoadAllAssetsAsync(Type type)
		{
			bool flag = type == null;
			if (flag)
			{
				throw new NullReferenceException("The input type cannot be null.");
			}
			return this.LoadAssetWithSubAssetsAsync_Internal("", type);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002CB4 File Offset: 0x00000EB4
		public Il2CppStringArray AllAssetNames()
		{
			return this.GetAllAssetNames();
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002090 File Offset: 0x00000290
		public void Unload(bool unloadAllLoadedObjects)
		{
			AssetBundle.UnloadDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), unloadAllLoadedObjects);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002CCC File Offset: 0x00000ECC
		public Il2CppStringArray GetAllAssetNames()
		{
			IntPtr intPtr = AssetBundle.GetAllAssetNamesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002CF8 File Offset: 0x00000EF8
		public Il2CppStringArray GetAllScenePaths()
		{
			IntPtr intPtr = AssetBundle.GetAllScenePathsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002D24 File Offset: 0x00000F24
		public Il2CppReferenceArray<Object> LoadAssetWithSubAssets_Internal(string name, Type type)
		{
			IntPtr intPtr = AssetBundle.LoadAssetWithSubAssets_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name), IL2CPP.Il2CppObjectBaseToPtr(type));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002D5C File Offset: 0x00000F5C
		public AssetBundleRequest LoadAssetWithSubAssetsAsync_Internal(string name, Type type)
		{
			IntPtr intPtr = AssetBundle.LoadAssetWithSubAssetsAsync_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name), IL2CPP.Il2CppObjectBaseToPtr(type));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr2) : null;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002D94 File Offset: 0x00000F94
		// (set) Token: 0x06000044 RID: 68 RVA: 0x000020A3 File Offset: 0x000002A3
		public static uint memoryBudgetKB
		{
			get
			{
				return AssetBundleLoadingCache.memoryBudgetKB;
			}
			set
			{
				AssetBundleLoadingCache.memoryBudgetKB = value;
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_UnloadAllAssetBundles_Public_Static_Void_Boolean_0;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_LoadFromFile_Internal_Internal_Static_AssetBundle_String_UInt32_UInt64_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_LoadFromFile_Public_Static_AssetBundle_String_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetAsync_Public_AssetBundleRequest_String_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetAsync_Public_AssetBundleRequest_String_Type_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetAsync_Internal_Private_AssetBundleRequest_String_Type_0;

		// Token: 0x04000008 RID: 8
		private static readonly AssetBundle.returnMainAssetDelegate returnMainAssetDelegateField;

		// Token: 0x04000009 RID: 9
		private static readonly AssetBundle.GetAllLoadedAssetBundles_NativeDelegate GetAllLoadedAssetBundles_NativeDelegateField;

		// Token: 0x0400000A RID: 10
		private static readonly AssetBundle.LoadFromFileAsync_InternalDelegate LoadFromFileAsync_InternalDelegateField;

		// Token: 0x0400000B RID: 11
		private static readonly AssetBundle.LoadFromMemoryAsync_InternalDelegate LoadFromMemoryAsync_InternalDelegateField;

		// Token: 0x0400000C RID: 12
		private static readonly AssetBundle.LoadFromMemory_InternalDelegate LoadFromMemory_InternalDelegateField;

		// Token: 0x0400000D RID: 13
		private static readonly AssetBundle.LoadFromStreamAsyncInternalDelegate LoadFromStreamAsyncInternalDelegateField;

		// Token: 0x0400000E RID: 14
		private static readonly AssetBundle.LoadFromStreamInternalDelegate LoadFromStreamInternalDelegateField;

		// Token: 0x0400000F RID: 15
		private static readonly AssetBundle.get_isStreamedSceneAssetBundleDelegate get_isStreamedSceneAssetBundleDelegateField;

		// Token: 0x04000010 RID: 16
		private static readonly AssetBundle.ContainsDelegate ContainsDelegateField;

		// Token: 0x04000011 RID: 17
		private static readonly AssetBundle.LoadAsset_InternalDelegate LoadAsset_InternalDelegateField;

		// Token: 0x04000012 RID: 18
		private static readonly AssetBundle.UnloadDelegate UnloadDelegateField;

		// Token: 0x04000013 RID: 19
		private static readonly AssetBundle.GetAllAssetNamesDelegate GetAllAssetNamesDelegateField;

		// Token: 0x04000014 RID: 20
		private static readonly AssetBundle.GetAllScenePathsDelegate GetAllScenePathsDelegateField;

		// Token: 0x04000015 RID: 21
		private static readonly AssetBundle.LoadAssetWithSubAssets_InternalDelegate LoadAssetWithSubAssets_InternalDelegateField;

		// Token: 0x04000016 RID: 22
		private static readonly AssetBundle.LoadAssetWithSubAssetsAsync_InternalDelegate LoadAssetWithSubAssetsAsync_InternalDelegateField;

		// Token: 0x0200000C RID: 12
		private sealed class MethodInfoStoreGeneric_LoadAssetAsync_Public_AssetBundleRequest_String_0<T>
		{
			// Token: 0x0400004A RID: 74
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AssetBundle.NativeMethodInfoPtr_LoadAssetAsync_Public_AssetBundleRequest_String_0, Il2CppClassPointerStore<AssetBundle>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x0600006A RID: 106
		private delegate IntPtr returnMainAssetDelegate(IntPtr bundle);

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x0600006C RID: 108
		private delegate IntPtr GetAllLoadedAssetBundles_NativeDelegate();

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x0600006E RID: 110
		private delegate IntPtr LoadFromFileAsync_InternalDelegate(IntPtr path, uint crc, ulong offset);

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x06000070 RID: 112
		private delegate IntPtr LoadFromMemoryAsync_InternalDelegate(IntPtr binary, uint crc);

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x06000072 RID: 114
		private delegate IntPtr LoadFromMemory_InternalDelegate(IntPtr binary, uint crc);

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x06000074 RID: 116
		private delegate IntPtr LoadFromStreamAsyncInternalDelegate(IntPtr stream, uint crc, uint managedReadBufferSize);

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x06000076 RID: 118
		private delegate IntPtr LoadFromStreamInternalDelegate(IntPtr stream, uint crc, uint managedReadBufferSize);

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x06000078 RID: 120
		private delegate bool get_isStreamedSceneAssetBundleDelegate(IntPtr @this);

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x0600007A RID: 122
		private delegate bool ContainsDelegate(IntPtr @this, IntPtr name);

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x0600007C RID: 124
		private delegate IntPtr LoadAsset_InternalDelegate(IntPtr @this, IntPtr name, IntPtr type);

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x0600007E RID: 126
		private delegate void UnloadDelegate(IntPtr @this, bool unloadAllLoadedObjects);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x06000080 RID: 128
		private delegate IntPtr GetAllAssetNamesDelegate(IntPtr @this);

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x06000082 RID: 130
		private delegate IntPtr GetAllScenePathsDelegate(IntPtr @this);

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x06000084 RID: 132
		private delegate IntPtr LoadAssetWithSubAssets_InternalDelegate(IntPtr @this, IntPtr name, IntPtr type);

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x06000086 RID: 134
		private delegate IntPtr LoadAssetWithSubAssetsAsync_InternalDelegate(IntPtr @this, IntPtr name, IntPtr type);
	}
}
