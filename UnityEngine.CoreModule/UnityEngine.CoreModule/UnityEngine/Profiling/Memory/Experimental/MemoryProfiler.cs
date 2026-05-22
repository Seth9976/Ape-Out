using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Profiling.Experimental;

namespace UnityEngine.Profiling.Memory.Experimental
{
	// Token: 0x02000110 RID: 272
	public sealed class MemoryProfiler : Object
	{
		// Token: 0x0600170F RID: 5903 RVA: 0x000595F8 File Offset: 0x000577F8
		// Note: this type is marked as 'beforefieldinit'.
		static MemoryProfiler()
		{
			Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Profiling.Memory.Experimental", "MemoryProfiler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr);
			MemoryProfiler.NativeFieldInfoPtr_m_SnapshotFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, "m_SnapshotFinished");
			MemoryProfiler.NativeFieldInfoPtr_m_SaveScreenshotToDisk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, "m_SaveScreenshotToDisk");
			MemoryProfiler.NativeFieldInfoPtr_createMetaData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, "createMetaData");
			MemoryProfiler.NativeMethodInfoPtr_PrepareMetadata_Private_Static_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100665344);
			MemoryProfiler.NativeMethodInfoPtr_WriteIntToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100665345);
			MemoryProfiler.NativeMethodInfoPtr_WriteStringToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100665346);
			MemoryProfiler.NativeMethodInfoPtr_FinalizeSnapshot_Private_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100665347);
			MemoryProfiler.NativeMethodInfoPtr_SaveScreenshotToDisk_Private_Static_Void_String_Boolean_IntPtr_Int32_TextureFormat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100665348);
			MemoryProfiler.StartOperationDelegateField = IL2CPP.ResolveICall<MemoryProfiler.StartOperationDelegate>("UnityEngine.Profiling.Memory.Experimental.MemoryProfiler::StartOperation");
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x000596D8 File Offset: 0x000578D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500296, XrefRangeEnd = 500316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> PrepareMetadata()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryProfiler.NativeMethodInfoPtr_PrepareMetadata_Private_Static_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06001711 RID: 5905 RVA: 0x0005970C File Offset: 0x0005790C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 500316, RefRangeEnd = 500318, XrefRangeStart = 500316, XrefRangeEnd = 500316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int WriteIntToByteArray(Il2CppStructArray<byte> array, int offset, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryProfiler.NativeMethodInfoPtr_WriteIntToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x0005976C File Offset: 0x0005796C
		[CallerCount(0)]
		public unsafe static int WriteStringToByteArray(Il2CppStructArray<byte> array, int offset, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryProfiler.NativeMethodInfoPtr_WriteStringToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x000597D0 File Offset: 0x000579D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500318, XrefRangeEnd = 500323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FinalizeSnapshot(string path, bool result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryProfiler.NativeMethodInfoPtr_FinalizeSnapshot_Private_Static_Void_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x00059814 File Offset: 0x00057A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500323, XrefRangeEnd = 500329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SaveScreenshotToDisk(string path, bool result, IntPtr pixelsPtr, int pixelsCount, TextureFormat format, int width, int height)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref result;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryProfiler.NativeMethodInfoPtr_SaveScreenshotToDisk_Private_Static_Void_String_Boolean_IntPtr_Int32_TextureFormat_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x0000C55C File Offset: 0x0000A75C
		public MemoryProfiler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06001716 RID: 5910 RVA: 0x000598A0 File Offset: 0x00057AA0
		// (set) Token: 0x06001717 RID: 5911 RVA: 0x0000C565 File Offset: 0x0000A765
		public unsafe static Action<string, bool> m_SnapshotFinished
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MemoryProfiler.NativeFieldInfoPtr_m_SnapshotFinished, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MemoryProfiler.NativeFieldInfoPtr_m_SnapshotFinished, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06001718 RID: 5912 RVA: 0x000598C8 File Offset: 0x00057AC8
		// (set) Token: 0x06001719 RID: 5913 RVA: 0x0000C577 File Offset: 0x0000A777
		public unsafe static Action<string, bool, UnityEngine.Profiling.Experimental.DebugScreenCapture> m_SaveScreenshotToDisk
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MemoryProfiler.NativeFieldInfoPtr_m_SaveScreenshotToDisk, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, bool, UnityEngine.Profiling.Experimental.DebugScreenCapture>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MemoryProfiler.NativeFieldInfoPtr_m_SaveScreenshotToDisk, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x0600171A RID: 5914 RVA: 0x000598F0 File Offset: 0x00057AF0
		// (set) Token: 0x0600171B RID: 5915 RVA: 0x0000C589 File Offset: 0x0000A789
		public unsafe static Action<MetaData> createMetaData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MemoryProfiler.NativeFieldInfoPtr_createMetaData, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<MetaData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MemoryProfiler.NativeFieldInfoPtr_createMetaData, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x0000C59B File Offset: 0x0000A79B
		public static void add_createMetaData(Action<MetaData> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x0000C5A8 File Offset: 0x0000A7A8
		public static void remove_createMetaData(Action<MetaData> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x0000C5B5 File Offset: 0x0000A7B5
		public static void StartOperation(uint captureFlag, bool requestScreenshot, string path, bool isRemote)
		{
			MemoryProfiler.StartOperationDelegateField(captureFlag, requestScreenshot, IL2CPP.ManagedStringToIl2Cpp(path), isRemote);
		}

		// Token: 0x04001203 RID: 4611
		private static readonly IntPtr NativeFieldInfoPtr_m_SnapshotFinished;

		// Token: 0x04001204 RID: 4612
		private static readonly IntPtr NativeFieldInfoPtr_m_SaveScreenshotToDisk;

		// Token: 0x04001205 RID: 4613
		private static readonly IntPtr NativeFieldInfoPtr_createMetaData;

		// Token: 0x04001206 RID: 4614
		private static readonly IntPtr NativeMethodInfoPtr_PrepareMetadata_Private_Static_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001207 RID: 4615
		private static readonly IntPtr NativeMethodInfoPtr_WriteIntToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001208 RID: 4616
		private static readonly IntPtr NativeMethodInfoPtr_WriteStringToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_String_0;

		// Token: 0x04001209 RID: 4617
		private static readonly IntPtr NativeMethodInfoPtr_FinalizeSnapshot_Private_Static_Void_String_Boolean_0;

		// Token: 0x0400120A RID: 4618
		private static readonly IntPtr NativeMethodInfoPtr_SaveScreenshotToDisk_Private_Static_Void_String_Boolean_IntPtr_Int32_TextureFormat_Int32_Int32_0;

		// Token: 0x0400120B RID: 4619
		private static readonly MemoryProfiler.StartOperationDelegate StartOperationDelegateField;

		// Token: 0x0200088F RID: 2191
		// (Invoke) Token: 0x06002F27 RID: 12071
		private delegate void StartOperationDelegate(uint captureFlag, bool requestScreenshot, IntPtr path, bool isRemote);
	}
}
