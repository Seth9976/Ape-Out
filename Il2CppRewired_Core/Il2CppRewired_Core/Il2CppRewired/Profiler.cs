using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired
{
	// Token: 0x02000030 RID: 48
	public static class Profiler : global::Il2CppSystem.Object
	{
		// Token: 0x0600038D RID: 909 RVA: 0x0003B71C File Offset: 0x0003991C
		// Note: this type is marked as 'beforefieldinit'.
		static Profiler()
		{
			Il2CppClassPointerStore<Profiler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "Profiler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Profiler>.NativeClassPtr);
			Profiler.NativeFieldInfoPtr_UCbfBqiiXLAPUacYVujiuwAHuNzu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiler>.NativeClassPtr, "UCbfBqiiXLAPUacYVujiuwAHuNzu");
			Profiler.NativeMethodInfoPtr_CZcYmSvPySpaUjMgVMSKzSejIqd_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100663872);
			Profiler.NativeMethodInfoPtr_get_enableBinaryLog_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100663873);
			Profiler.NativeMethodInfoPtr_set_enableBinaryLog_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100663874);
			Profiler.NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100663875);
			Profiler.NativeMethodInfoPtr_set_enabled_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100663876);
			Profiler.NativeMethodInfoPtr_get_logFile_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100663877);
			Profiler.NativeMethodInfoPtr_set_logFile_Public_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100663878);
			Profiler.NativeMethodInfoPtr_get_supported_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100663879);
			Profiler.NativeMethodInfoPtr_get_usedHeapSize_Public_Static_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100663880);
			Profiler.NativeMethodInfoPtr_get_usedHeapSizeLong_Public_Static_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100663881);
			Profiler.NativeMethodInfoPtr_AddFramesFromFile_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100663882);
			Profiler.NativeMethodInfoPtr_BeginSample_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100663883);
			Profiler.NativeMethodInfoPtr_BeginSample_Public_Static_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100663884);
			Profiler.NativeMethodInfoPtr_EndSample_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100663885);
			Profiler.NativeMethodInfoPtr_GetMonoHeapSize_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100663886);
			Profiler.NativeMethodInfoPtr_GetMonoHeapSizeLong_Public_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100663887);
			Profiler.NativeMethodInfoPtr_GetMonoUsedSize_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100663888);
			Profiler.NativeMethodInfoPtr_GetMonoUsedSizeLong_Public_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100663889);
			Profiler.NativeMethodInfoPtr_GetRuntimeMemorySize_Public_Static_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100663890);
			Profiler.NativeMethodInfoPtr_GetRuntimeMemorySizeLong_Public_Static_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100663891);
			Profiler.NativeMethodInfoPtr_GetTotalAllocatedMemory_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100663892);
			Profiler.NativeMethodInfoPtr_GetTotalAllocatedMemoryLong_Public_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100663893);
			Profiler.NativeMethodInfoPtr_GetTotalReservedMemory_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100663894);
			Profiler.NativeMethodInfoPtr_GetTotalReservedMemoryLong_Public_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100663895);
			Profiler.NativeMethodInfoPtr_GetTotalUnusedReservedMemory_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100663896);
			Profiler.NativeMethodInfoPtr_GetTotalUnusedReservedMemoryLong_Public_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100663897);
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0003B968 File Offset: 0x00039B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244737, XrefRangeEnd = 244740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CZcYmSvPySpaUjMgVMSKzSejIqd()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_CZcYmSvPySpaUjMgVMSKzSejIqd_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600038F RID: 911 RVA: 0x0003B990 File Offset: 0x00039B90
		// (set) Token: 0x06000390 RID: 912 RVA: 0x0003B9C0 File Offset: 0x00039BC0
		public unsafe static bool enableBinaryLog
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244740, XrefRangeEnd = 244743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_get_enableBinaryLog_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_set_enableBinaryLog_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000391 RID: 913 RVA: 0x0003B9F4 File Offset: 0x00039BF4
		// (set) Token: 0x06000392 RID: 914 RVA: 0x0003BA24 File Offset: 0x00039C24
		public unsafe static bool enabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_set_enabled_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000393 RID: 915 RVA: 0x0003BA58 File Offset: 0x00039C58
		// (set) Token: 0x06000394 RID: 916 RVA: 0x0003BA84 File Offset: 0x00039C84
		public unsafe static string logFile
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244743, XrefRangeEnd = 244748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_get_logFile_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_set_logFile_Public_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000395 RID: 917 RVA: 0x0003BABC File Offset: 0x00039CBC
		public unsafe static bool supported
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_get_supported_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000396 RID: 918 RVA: 0x0003BAEC File Offset: 0x00039CEC
		public unsafe static uint usedHeapSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244748, XrefRangeEnd = 244751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_get_usedHeapSize_Public_Static_get_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000397 RID: 919 RVA: 0x0003BB1C File Offset: 0x00039D1C
		public unsafe static long usedHeapSizeLong
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_get_usedHeapSizeLong_Public_Static_get_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0003BB4C File Offset: 0x00039D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddFramesFromFile(string file)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_AddFramesFromFile_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0003BB84 File Offset: 0x00039D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginSample(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_BeginSample_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0003BBBC File Offset: 0x00039DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginSample(string name, global::UnityEngine.Object targetObject)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_BeginSample_Public_Static_Void_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0003BC04 File Offset: 0x00039E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndSample()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_EndSample_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0003BC2C File Offset: 0x00039E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetMonoHeapSize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_GetMonoHeapSize_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0003BC5C File Offset: 0x00039E5C
		[CallerCount(0)]
		public unsafe static long GetMonoHeapSizeLong()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_GetMonoHeapSizeLong_Public_Static_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0003BC8C File Offset: 0x00039E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetMonoUsedSize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_GetMonoUsedSize_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0003BCBC File Offset: 0x00039EBC
		[CallerCount(0)]
		public unsafe static long GetMonoUsedSizeLong()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_GetMonoUsedSizeLong_Public_Static_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0003BCEC File Offset: 0x00039EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetRuntimeMemorySize(global::UnityEngine.Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_GetRuntimeMemorySize_Public_Static_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0003BD30 File Offset: 0x00039F30
		[CallerCount(0)]
		public unsafe static long GetRuntimeMemorySizeLong(global::UnityEngine.Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_GetRuntimeMemorySizeLong_Public_Static_Int64_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0003BD74 File Offset: 0x00039F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetTotalAllocatedMemory()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_GetTotalAllocatedMemory_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0003BDA4 File Offset: 0x00039FA4
		[CallerCount(0)]
		public unsafe static long GetTotalAllocatedMemoryLong()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_GetTotalAllocatedMemoryLong_Public_Static_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0003BDD4 File Offset: 0x00039FD4
		[CallerCount(0)]
		public unsafe static uint GetTotalReservedMemory()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_GetTotalReservedMemory_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0003BE04 File Offset: 0x0003A004
		[CallerCount(0)]
		public unsafe static long GetTotalReservedMemoryLong()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_GetTotalReservedMemoryLong_Public_Static_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0003BE34 File Offset: 0x0003A034
		[CallerCount(0)]
		public unsafe static uint GetTotalUnusedReservedMemory()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_GetTotalUnusedReservedMemory_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0003BE64 File Offset: 0x0003A064
		[CallerCount(0)]
		public unsafe static long GetTotalUnusedReservedMemoryLong()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_GetTotalUnusedReservedMemoryLong_Public_Static_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x000032A5 File Offset: 0x000014A5
		public Profiler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x0003BE94 File Offset: 0x0003A094
		// (set) Token: 0x060003AA RID: 938 RVA: 0x000032AE File Offset: 0x000014AE
		public unsafe static string UCbfBqiiXLAPUacYVujiuwAHuNzu
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Profiler.NativeFieldInfoPtr_UCbfBqiiXLAPUacYVujiuwAHuNzu, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Profiler.NativeFieldInfoPtr_UCbfBqiiXLAPUacYVujiuwAHuNzu, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeFieldInfoPtr_UCbfBqiiXLAPUacYVujiuwAHuNzu;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeMethodInfoPtr_CZcYmSvPySpaUjMgVMSKzSejIqd_Private_Static_Void_0;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeMethodInfoPtr_get_enableBinaryLog_Public_Static_get_Boolean_0;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeMethodInfoPtr_set_enableBinaryLog_Public_Static_set_Void_Boolean_0;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_Static_set_Void_Boolean_0;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeMethodInfoPtr_get_logFile_Public_Static_get_String_0;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeMethodInfoPtr_set_logFile_Public_Static_set_Void_String_0;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeMethodInfoPtr_get_supported_Public_Static_get_Boolean_0;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeMethodInfoPtr_get_usedHeapSize_Public_Static_get_UInt32_0;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeMethodInfoPtr_get_usedHeapSizeLong_Public_Static_get_Int64_0;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeMethodInfoPtr_AddFramesFromFile_Public_Static_Void_String_0;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeMethodInfoPtr_BeginSample_Public_Static_Void_String_0;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeMethodInfoPtr_BeginSample_Public_Static_Void_String_Object_0;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeMethodInfoPtr_EndSample_Public_Static_Void_0;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeMethodInfoPtr_GetMonoHeapSize_Public_Static_UInt32_0;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeMethodInfoPtr_GetMonoHeapSizeLong_Public_Static_Int64_0;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeMethodInfoPtr_GetMonoUsedSize_Public_Static_UInt32_0;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeMethodInfoPtr_GetMonoUsedSizeLong_Public_Static_Int64_0;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeMethodInfoPtr_GetRuntimeMemorySize_Public_Static_Int32_Object_0;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeMethodInfoPtr_GetRuntimeMemorySizeLong_Public_Static_Int64_Object_0;

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalAllocatedMemory_Public_Static_UInt32_0;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalAllocatedMemoryLong_Public_Static_Int64_0;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalReservedMemory_Public_Static_UInt32_0;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalReservedMemoryLong_Public_Static_Int64_0;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalUnusedReservedMemory_Public_Static_UInt32_0;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalUnusedReservedMemoryLong_Public_Static_Int64_0;
	}
}
