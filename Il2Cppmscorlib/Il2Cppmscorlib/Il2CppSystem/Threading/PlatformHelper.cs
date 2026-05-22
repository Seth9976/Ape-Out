using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000267 RID: 615
	public static class PlatformHelper : Object
	{
		// Token: 0x06002B0E RID: 11022 RVA: 0x000E03FC File Offset: 0x000DE5FC
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformHelper()
		{
			Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "PlatformHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr);
			PlatformHelper.NativeFieldInfoPtr_s_processorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr, "s_processorCount");
			PlatformHelper.NativeFieldInfoPtr_s_lastProcessorCountRefreshTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr, "s_lastProcessorCountRefreshTicks");
			PlatformHelper.NativeMethodInfoPtr_get_ProcessorCount_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr, 100670214);
			PlatformHelper.NativeMethodInfoPtr_get_IsSingleProcessor_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr, 100670215);
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06002B0F RID: 11023 RVA: 0x000E047C File Offset: 0x000DE67C
		public unsafe static int ProcessorCount
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 200956, RefRangeEnd = 200974, XrefRangeStart = 200951, XrefRangeEnd = 200956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformHelper.NativeMethodInfoPtr_get_ProcessorCount_Internal_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06002B10 RID: 11024 RVA: 0x000E04AC File Offset: 0x000DE6AC
		public unsafe static bool IsSingleProcessor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200974, XrefRangeEnd = 200975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformHelper.NativeMethodInfoPtr_get_IsSingleProcessor_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B11 RID: 11025 RVA: 0x0000EDD5 File Offset: 0x0000CFD5
		public PlatformHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06002B12 RID: 11026 RVA: 0x000E04DC File Offset: 0x000DE6DC
		// (set) Token: 0x06002B13 RID: 11027 RVA: 0x0000EDDE File Offset: 0x0000CFDE
		public unsafe static int s_processorCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PlatformHelper.NativeFieldInfoPtr_s_processorCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformHelper.NativeFieldInfoPtr_s_processorCount, (void*)(&value));
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06002B14 RID: 11028 RVA: 0x000E04F8 File Offset: 0x000DE6F8
		// (set) Token: 0x06002B15 RID: 11029 RVA: 0x0000EDEC File Offset: 0x0000CFEC
		public unsafe static int s_lastProcessorCountRefreshTicks
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PlatformHelper.NativeFieldInfoPtr_s_lastProcessorCountRefreshTicks, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformHelper.NativeFieldInfoPtr_s_lastProcessorCountRefreshTicks, (void*)(&value));
			}
		}

		// Token: 0x040025C4 RID: 9668
		private static readonly IntPtr NativeFieldInfoPtr_s_processorCount;

		// Token: 0x040025C5 RID: 9669
		private static readonly IntPtr NativeFieldInfoPtr_s_lastProcessorCountRefreshTicks;

		// Token: 0x040025C6 RID: 9670
		private static readonly IntPtr NativeMethodInfoPtr_get_ProcessorCount_Internal_Static_get_Int32_0;

		// Token: 0x040025C7 RID: 9671
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSingleProcessor_Internal_Static_get_Boolean_0;
	}
}
