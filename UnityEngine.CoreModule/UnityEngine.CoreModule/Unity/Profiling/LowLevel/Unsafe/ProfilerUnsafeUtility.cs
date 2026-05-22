using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Unity.Profiling.LowLevel.Unsafe
{
	// Token: 0x0200000C RID: 12
	public static class ProfilerUnsafeUtility : global::Il2CppSystem.Object
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00015B34 File Offset: 0x00013D34
		// Note: this type is marked as 'beforefieldinit'.
		static ProfilerUnsafeUtility()
		{
			Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling.LowLevel.Unsafe", "ProfilerUnsafeUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr);
			ProfilerUnsafeUtility.NativeMethodInfoPtr_CreateMarker_Public_Static_IntPtr_String_UInt16_MarkerFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663306);
			ProfilerUnsafeUtility.GetCategoryByNameDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.GetCategoryByNameDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::GetCategoryByName");
			ProfilerUnsafeUtility.GetCategoryByName__UnmanagedDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.GetCategoryByName__UnmanagedDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::GetCategoryByName__Unmanaged");
			ProfilerUnsafeUtility.GetCategoryByName_UnsafeDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.GetCategoryByName_UnsafeDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::GetCategoryByName_Unsafe");
			ProfilerUnsafeUtility.CreateMarker__UnmanagedDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.CreateMarker__UnmanagedDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateMarker__Unmanaged");
			ProfilerUnsafeUtility.CreateMarker_UnsafeDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.CreateMarker_UnsafeDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateMarker_Unsafe");
			ProfilerUnsafeUtility.SetMarkerMetadataDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.SetMarkerMetadataDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::SetMarkerMetadata");
			ProfilerUnsafeUtility.SetMarkerMetadata__UnmanagedDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.SetMarkerMetadata__UnmanagedDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::SetMarkerMetadata__Unmanaged");
			ProfilerUnsafeUtility.SetMarkerMetadata_UnsafeDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.SetMarkerMetadata_UnsafeDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::SetMarkerMetadata_Unsafe");
			ProfilerUnsafeUtility.BeginSampleDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.BeginSampleDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::BeginSample");
			ProfilerUnsafeUtility.BeginSampleWithMetadataDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.BeginSampleWithMetadataDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::BeginSampleWithMetadata");
			ProfilerUnsafeUtility.EndSampleDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.EndSampleDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::EndSample");
			ProfilerUnsafeUtility.SingleSampleWithMetadataDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.SingleSampleWithMetadataDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::SingleSampleWithMetadata");
			ProfilerUnsafeUtility.CreateCounterValueDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.CreateCounterValueDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateCounterValue");
			ProfilerUnsafeUtility.CreateCounterValue__UnmanagedDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.CreateCounterValue__UnmanagedDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateCounterValue__Unmanaged");
			ProfilerUnsafeUtility.CreateCounterValue_UnsafeDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.CreateCounterValue_UnsafeDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateCounterValue_Unsafe");
			ProfilerUnsafeUtility.FlushCounterValueDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.FlushCounterValueDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::FlushCounterValue");
			ProfilerUnsafeUtility.CreateFlowDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.CreateFlowDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateFlow");
			ProfilerUnsafeUtility.FlowEventDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.FlowEventDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::FlowEvent");
			ProfilerUnsafeUtility.Internal_BeginWithObjectDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.Internal_BeginWithObjectDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::Internal_BeginWithObject");
			ProfilerUnsafeUtility.Internal_GetNameDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.Internal_GetNameDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::Internal_GetName");
			ProfilerUnsafeUtility.get_TimestampDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.get_TimestampDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::get_Timestamp");
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00015CB4 File Offset: 0x00013EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485692, XrefRangeEnd = 485696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateMarker(string name, ushort categoryId, MarkerFlags flags, int metadataCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref categoryId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref metadataCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerUnsafeUtility.NativeMethodInfoPtr_CreateMarker_Public_Static_IntPtr_String_UInt16_MarkerFlags_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002214 File Offset: 0x00000414
		public ProfilerUnsafeUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000221D File Offset: 0x0000041D
		public static ushort GetCategoryByName(string name)
		{
			return ProfilerUnsafeUtility.GetCategoryByNameDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000222F File Offset: 0x0000042F
		public unsafe static ushort GetCategoryByName__Unmanaged(byte* name, int nameLen)
		{
			return ProfilerUnsafeUtility.GetCategoryByName__UnmanagedDelegateField(name, nameLen);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00015D20 File Offset: 0x00013F20
		public unsafe static ushort GetCategoryByName(char* name, int nameLen)
		{
			return ProfilerUnsafeUtility.GetCategoryByName_Unsafe(name, nameLen);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000223D File Offset: 0x0000043D
		public unsafe static ushort GetCategoryByName_Unsafe(char* name, int nameLen)
		{
			return ProfilerUnsafeUtility.GetCategoryByName_UnsafeDelegateField(name, nameLen);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000224B File Offset: 0x0000044B
		public unsafe static IntPtr CreateMarker__Unmanaged(byte* name, int nameLen, ushort categoryId, MarkerFlags flags, int metadataCount)
		{
			return ProfilerUnsafeUtility.CreateMarker__UnmanagedDelegateField(name, nameLen, categoryId, flags, metadataCount);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00015D3C File Offset: 0x00013F3C
		public unsafe static IntPtr CreateMarker(char* name, int nameLen, ushort categoryId, MarkerFlags flags, int metadataCount)
		{
			return ProfilerUnsafeUtility.CreateMarker_Unsafe(name, nameLen, categoryId, flags, metadataCount);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000225D File Offset: 0x0000045D
		public unsafe static IntPtr CreateMarker_Unsafe(char* name, int nameLen, ushort categoryId, MarkerFlags flags, int metadataCount)
		{
			return ProfilerUnsafeUtility.CreateMarker_UnsafeDelegateField(name, nameLen, categoryId, flags, metadataCount);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000226F File Offset: 0x0000046F
		public static void SetMarkerMetadata(IntPtr markerPtr, int index, string name, byte type, byte unit)
		{
			ProfilerUnsafeUtility.SetMarkerMetadataDelegateField(markerPtr, index, IL2CPP.ManagedStringToIl2Cpp(name), type, unit);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002286 File Offset: 0x00000486
		public unsafe static void SetMarkerMetadata__Unmanaged(IntPtr markerPtr, int index, byte* name, int nameLen, byte type, byte unit)
		{
			ProfilerUnsafeUtility.SetMarkerMetadata__UnmanagedDelegateField(markerPtr, index, name, nameLen, type, unit);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000229A File Offset: 0x0000049A
		public unsafe static void SetMarkerMetadata(IntPtr markerPtr, int index, char* name, int nameLen, byte type, byte unit)
		{
			ProfilerUnsafeUtility.SetMarkerMetadata_Unsafe(markerPtr, index, name, nameLen, type, unit);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000022AB File Offset: 0x000004AB
		public unsafe static void SetMarkerMetadata_Unsafe(IntPtr markerPtr, int index, char* name, int nameLen, byte type, byte unit)
		{
			ProfilerUnsafeUtility.SetMarkerMetadata_UnsafeDelegateField(markerPtr, index, name, nameLen, type, unit);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000022BF File Offset: 0x000004BF
		public static void BeginSample(IntPtr markerPtr)
		{
			ProfilerUnsafeUtility.BeginSampleDelegateField(markerPtr);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000022CC File Offset: 0x000004CC
		public unsafe static void BeginSampleWithMetadata(IntPtr markerPtr, int metadataCount, void* metadata)
		{
			ProfilerUnsafeUtility.BeginSampleWithMetadataDelegateField(markerPtr, metadataCount, metadata);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000022DB File Offset: 0x000004DB
		public static void EndSample(IntPtr markerPtr)
		{
			ProfilerUnsafeUtility.EndSampleDelegateField(markerPtr);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000022E8 File Offset: 0x000004E8
		public unsafe static void SingleSampleWithMetadata(IntPtr markerPtr, int metadataCount, void* metadata)
		{
			ProfilerUnsafeUtility.SingleSampleWithMetadataDelegateField(markerPtr, metadataCount, metadata);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00015D5C File Offset: 0x00013F5C
		public unsafe static void* CreateCounterValue(out IntPtr counterPtr, string name, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions)
		{
			return ProfilerUnsafeUtility.CreateCounterValueDelegateField(out counterPtr, IL2CPP.ManagedStringToIl2Cpp(name), categoryId, flags, dataType, dataUnit, dataSize, counterOptions);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00015D84 File Offset: 0x00013F84
		public unsafe static void* CreateCounterValue__Unmanaged(out IntPtr counterPtr, byte* name, int nameLen, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions)
		{
			return ProfilerUnsafeUtility.CreateCounterValue__UnmanagedDelegateField(out counterPtr, name, nameLen, categoryId, flags, dataType, dataUnit, dataSize, counterOptions);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00015DAC File Offset: 0x00013FAC
		public unsafe static void* CreateCounterValue(out IntPtr counterPtr, char* name, int nameLen, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions)
		{
			return ProfilerUnsafeUtility.CreateCounterValue_Unsafe(out counterPtr, name, nameLen, categoryId, flags, dataType, dataUnit, dataSize, counterOptions);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00015DD4 File Offset: 0x00013FD4
		public unsafe static void* CreateCounterValue_Unsafe(out IntPtr counterPtr, char* name, int nameLen, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions)
		{
			return ProfilerUnsafeUtility.CreateCounterValue_UnsafeDelegateField(out counterPtr, name, nameLen, categoryId, flags, dataType, dataUnit, dataSize, counterOptions);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000022F7 File Offset: 0x000004F7
		public unsafe static void FlushCounterValue(void* counterValuePtr)
		{
			ProfilerUnsafeUtility.FlushCounterValueDelegateField(counterValuePtr);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002304 File Offset: 0x00000504
		public unsafe static string Utf8ToString(byte* chars, int charsLen)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002311 File Offset: 0x00000511
		public static uint CreateFlow(ushort categoryId)
		{
			return ProfilerUnsafeUtility.CreateFlowDelegateField(categoryId);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000231E File Offset: 0x0000051E
		public static void FlowEvent(uint flowId, ProfilerFlowEventType flowEventType)
		{
			ProfilerUnsafeUtility.FlowEventDelegateField(flowId, flowEventType);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000232C File Offset: 0x0000052C
		public static void Internal_BeginWithObject(IntPtr markerPtr, global::UnityEngine.Object contextUnityObject)
		{
			ProfilerUnsafeUtility.Internal_BeginWithObjectDelegateField(markerPtr, IL2CPP.Il2CppObjectBaseToPtr(contextUnityObject));
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00015DFC File Offset: 0x00013FFC
		public static string Internal_GetName(IntPtr markerPtr)
		{
			IntPtr intPtr = ProfilerUnsafeUtility.Internal_GetNameDelegateField(markerPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000040 RID: 64 RVA: 0x0000233F File Offset: 0x0000053F
		public static long Timestamp
		{
			get
			{
				return ProfilerUnsafeUtility.get_TimestampDelegateField();
			}
		}

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_CreateMarker_Public_Static_IntPtr_String_UInt16_MarkerFlags_Int32_0;

		// Token: 0x04000021 RID: 33
		public const ushort CategoryRender = 0;

		// Token: 0x04000022 RID: 34
		public const ushort CategoryScripts = 1;

		// Token: 0x04000023 RID: 35
		public const ushort CategoryGUI = 4;

		// Token: 0x04000024 RID: 36
		public const ushort CategoryPhysics = 5;

		// Token: 0x04000025 RID: 37
		public const ushort CategoryAnimation = 6;

		// Token: 0x04000026 RID: 38
		public const ushort CategoryAi = 7;

		// Token: 0x04000027 RID: 39
		public const ushort CategoryAudio = 8;

		// Token: 0x04000028 RID: 40
		public const ushort CategoryVideo = 11;

		// Token: 0x04000029 RID: 41
		public const ushort CategoryParticles = 12;

		// Token: 0x0400002A RID: 42
		public const ushort CategoryLighting = 13;

		// Token: 0x0400002B RID: 43
		public const ushort CategoryLightning = 13;

		// Token: 0x0400002C RID: 44
		public const ushort CategoryNetwork = 14;

		// Token: 0x0400002D RID: 45
		public const ushort CategoryLoading = 15;

		// Token: 0x0400002E RID: 46
		public const ushort CategoryOther = 16;

		// Token: 0x0400002F RID: 47
		public const ushort CategoryVr = 22;

		// Token: 0x04000030 RID: 48
		public const ushort CategoryAllocation = 23;

		// Token: 0x04000031 RID: 49
		public const ushort CategoryInternal = 24;

		// Token: 0x04000032 RID: 50
		public const ushort CategoryInput = 30;

		// Token: 0x04000033 RID: 51
		public const ushort CategoryVirtualTexturing = 31;

		// Token: 0x04000034 RID: 52
		public const ushort CategoryAny = 65535;

		// Token: 0x04000035 RID: 53
		private static readonly ProfilerUnsafeUtility.GetCategoryByNameDelegate GetCategoryByNameDelegateField;

		// Token: 0x04000036 RID: 54
		private static readonly ProfilerUnsafeUtility.GetCategoryByName__UnmanagedDelegate GetCategoryByName__UnmanagedDelegateField;

		// Token: 0x04000037 RID: 55
		private static readonly ProfilerUnsafeUtility.GetCategoryByName_UnsafeDelegate GetCategoryByName_UnsafeDelegateField;

		// Token: 0x04000038 RID: 56
		private static readonly ProfilerUnsafeUtility.CreateMarker__UnmanagedDelegate CreateMarker__UnmanagedDelegateField;

		// Token: 0x04000039 RID: 57
		private static readonly ProfilerUnsafeUtility.CreateMarker_UnsafeDelegate CreateMarker_UnsafeDelegateField;

		// Token: 0x0400003A RID: 58
		private static readonly ProfilerUnsafeUtility.SetMarkerMetadataDelegate SetMarkerMetadataDelegateField;

		// Token: 0x0400003B RID: 59
		private static readonly ProfilerUnsafeUtility.SetMarkerMetadata__UnmanagedDelegate SetMarkerMetadata__UnmanagedDelegateField;

		// Token: 0x0400003C RID: 60
		private static readonly ProfilerUnsafeUtility.SetMarkerMetadata_UnsafeDelegate SetMarkerMetadata_UnsafeDelegateField;

		// Token: 0x0400003D RID: 61
		private static readonly ProfilerUnsafeUtility.BeginSampleDelegate BeginSampleDelegateField;

		// Token: 0x0400003E RID: 62
		private static readonly ProfilerUnsafeUtility.BeginSampleWithMetadataDelegate BeginSampleWithMetadataDelegateField;

		// Token: 0x0400003F RID: 63
		private static readonly ProfilerUnsafeUtility.EndSampleDelegate EndSampleDelegateField;

		// Token: 0x04000040 RID: 64
		private static readonly ProfilerUnsafeUtility.SingleSampleWithMetadataDelegate SingleSampleWithMetadataDelegateField;

		// Token: 0x04000041 RID: 65
		private static readonly ProfilerUnsafeUtility.CreateCounterValueDelegate CreateCounterValueDelegateField;

		// Token: 0x04000042 RID: 66
		private static readonly ProfilerUnsafeUtility.CreateCounterValue__UnmanagedDelegate CreateCounterValue__UnmanagedDelegateField;

		// Token: 0x04000043 RID: 67
		private static readonly ProfilerUnsafeUtility.CreateCounterValue_UnsafeDelegate CreateCounterValue_UnsafeDelegateField;

		// Token: 0x04000044 RID: 68
		private static readonly ProfilerUnsafeUtility.FlushCounterValueDelegate FlushCounterValueDelegateField;

		// Token: 0x04000045 RID: 69
		private static readonly ProfilerUnsafeUtility.CreateFlowDelegate CreateFlowDelegateField;

		// Token: 0x04000046 RID: 70
		private static readonly ProfilerUnsafeUtility.FlowEventDelegate FlowEventDelegateField;

		// Token: 0x04000047 RID: 71
		private static readonly ProfilerUnsafeUtility.Internal_BeginWithObjectDelegate Internal_BeginWithObjectDelegateField;

		// Token: 0x04000048 RID: 72
		private static readonly ProfilerUnsafeUtility.Internal_GetNameDelegate Internal_GetNameDelegateField;

		// Token: 0x04000049 RID: 73
		private static readonly ProfilerUnsafeUtility.get_TimestampDelegate get_TimestampDelegateField;

		// Token: 0x020002E4 RID: 740
		// (Invoke) Token: 0x060023C3 RID: 9155
		private delegate ushort GetCategoryByNameDelegate(IntPtr name);

		// Token: 0x020002E5 RID: 741
		// (Invoke) Token: 0x060023C5 RID: 9157
		private delegate ushort GetCategoryByName__UnmanagedDelegate(IntPtr name, int nameLen);

		// Token: 0x020002E6 RID: 742
		// (Invoke) Token: 0x060023C7 RID: 9159
		private delegate ushort GetCategoryByName_UnsafeDelegate(IntPtr name, int nameLen);

		// Token: 0x020002E7 RID: 743
		// (Invoke) Token: 0x060023C9 RID: 9161
		private delegate IntPtr CreateMarker__UnmanagedDelegate(IntPtr name, int nameLen, ushort categoryId, MarkerFlags flags, int metadataCount);

		// Token: 0x020002E8 RID: 744
		// (Invoke) Token: 0x060023CB RID: 9163
		private delegate IntPtr CreateMarker_UnsafeDelegate(IntPtr name, int nameLen, ushort categoryId, MarkerFlags flags, int metadataCount);

		// Token: 0x020002E9 RID: 745
		// (Invoke) Token: 0x060023CD RID: 9165
		private delegate void SetMarkerMetadataDelegate(IntPtr markerPtr, int index, IntPtr name, byte type, byte unit);

		// Token: 0x020002EA RID: 746
		// (Invoke) Token: 0x060023CF RID: 9167
		private delegate void SetMarkerMetadata__UnmanagedDelegate(IntPtr markerPtr, int index, IntPtr name, int nameLen, byte type, byte unit);

		// Token: 0x020002EB RID: 747
		// (Invoke) Token: 0x060023D1 RID: 9169
		private delegate void SetMarkerMetadata_UnsafeDelegate(IntPtr markerPtr, int index, IntPtr name, int nameLen, byte type, byte unit);

		// Token: 0x020002EC RID: 748
		// (Invoke) Token: 0x060023D3 RID: 9171
		private delegate void BeginSampleDelegate(IntPtr markerPtr);

		// Token: 0x020002ED RID: 749
		// (Invoke) Token: 0x060023D5 RID: 9173
		private delegate void BeginSampleWithMetadataDelegate(IntPtr markerPtr, int metadataCount, IntPtr metadata);

		// Token: 0x020002EE RID: 750
		// (Invoke) Token: 0x060023D7 RID: 9175
		private delegate void EndSampleDelegate(IntPtr markerPtr);

		// Token: 0x020002EF RID: 751
		// (Invoke) Token: 0x060023D9 RID: 9177
		private delegate void SingleSampleWithMetadataDelegate(IntPtr markerPtr, int metadataCount, IntPtr metadata);

		// Token: 0x020002F0 RID: 752
		// (Invoke) Token: 0x060023DB RID: 9179
		private delegate IntPtr CreateCounterValueDelegate([Out] IntPtr counterPtr, IntPtr name, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions);

		// Token: 0x020002F1 RID: 753
		// (Invoke) Token: 0x060023DD RID: 9181
		private delegate IntPtr CreateCounterValue__UnmanagedDelegate([Out] IntPtr counterPtr, IntPtr name, int nameLen, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions);

		// Token: 0x020002F2 RID: 754
		// (Invoke) Token: 0x060023DF RID: 9183
		private delegate IntPtr CreateCounterValue_UnsafeDelegate([Out] IntPtr counterPtr, IntPtr name, int nameLen, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions);

		// Token: 0x020002F3 RID: 755
		// (Invoke) Token: 0x060023E1 RID: 9185
		private delegate void FlushCounterValueDelegate(IntPtr counterValuePtr);

		// Token: 0x020002F4 RID: 756
		// (Invoke) Token: 0x060023E3 RID: 9187
		private delegate uint CreateFlowDelegate(ushort categoryId);

		// Token: 0x020002F5 RID: 757
		// (Invoke) Token: 0x060023E5 RID: 9189
		private delegate void FlowEventDelegate(uint flowId, ProfilerFlowEventType flowEventType);

		// Token: 0x020002F6 RID: 758
		// (Invoke) Token: 0x060023E7 RID: 9191
		private delegate void Internal_BeginWithObjectDelegate(IntPtr markerPtr, IntPtr contextUnityObject);

		// Token: 0x020002F7 RID: 759
		// (Invoke) Token: 0x060023E9 RID: 9193
		private delegate IntPtr Internal_GetNameDelegate(IntPtr markerPtr);

		// Token: 0x020002F8 RID: 760
		// (Invoke) Token: 0x060023EB RID: 9195
		private delegate long get_TimestampDelegate();
	}
}
