using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.Profiling
{
	// Token: 0x02000274 RID: 628
	public sealed class Profiler
	{
		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06002232 RID: 8754 RVA: 0x000122C4 File Offset: 0x000104C4
		public static bool supported
		{
			get
			{
				return Profiler.get_supportedDelegateField();
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06002233 RID: 8755 RVA: 0x00077D68 File Offset: 0x00075F68
		// (set) Token: 0x06002234 RID: 8756 RVA: 0x000122D0 File Offset: 0x000104D0
		public static string logFile
		{
			get
			{
				IntPtr intPtr = Profiler.get_logFileDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				Profiler.set_logFileDelegateField(IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06002235 RID: 8757 RVA: 0x000122E2 File Offset: 0x000104E2
		// (set) Token: 0x06002236 RID: 8758 RVA: 0x000122EE File Offset: 0x000104EE
		public static bool enableBinaryLog
		{
			get
			{
				return Profiler.get_enableBinaryLogDelegateField();
			}
			set
			{
				Profiler.set_enableBinaryLogDelegateField(value);
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06002237 RID: 8759 RVA: 0x000122FB File Offset: 0x000104FB
		// (set) Token: 0x06002238 RID: 8760 RVA: 0x00012307 File Offset: 0x00010507
		public static int maxUsedMemory
		{
			get
			{
				return Profiler.get_maxUsedMemoryDelegateField();
			}
			set
			{
				Profiler.set_maxUsedMemoryDelegateField(value);
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06002239 RID: 8761 RVA: 0x00012314 File Offset: 0x00010514
		// (set) Token: 0x0600223A RID: 8762 RVA: 0x00012320 File Offset: 0x00010520
		public static bool enabled
		{
			get
			{
				return Profiler.get_enabledDelegateField();
			}
			set
			{
				Profiler.set_enabledDelegateField(value);
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x0600223B RID: 8763 RVA: 0x0001232D File Offset: 0x0001052D
		// (set) Token: 0x0600223C RID: 8764 RVA: 0x00012339 File Offset: 0x00010539
		public static bool enableAllocationCallstacks
		{
			get
			{
				return Profiler.get_enableAllocationCallstacksDelegateField();
			}
			set
			{
				Profiler.set_enableAllocationCallstacksDelegateField(value);
			}
		}

		// Token: 0x0600223D RID: 8765 RVA: 0x00012346 File Offset: 0x00010546
		public static void SetAreaEnabled(ProfilerArea area, bool enabled)
		{
			Profiler.SetAreaEnabledDelegateField(area, enabled);
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x0600223E RID: 8766 RVA: 0x00077D88 File Offset: 0x00075F88
		public static int areaCount
		{
			get
			{
				return Enum.GetNames(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<ProfilerArea>())).Length;
			}
		}

		// Token: 0x0600223F RID: 8767 RVA: 0x00012354 File Offset: 0x00010554
		public static bool GetAreaEnabled(ProfilerArea area)
		{
			return Profiler.GetAreaEnabledDelegateField(area);
		}

		// Token: 0x06002240 RID: 8768 RVA: 0x00077DB0 File Offset: 0x00075FB0
		public static void AddFramesFromFile(string file)
		{
			bool flag = String.IsNullOrEmpty(file);
			if (flag)
			{
				Debug.LogError("AddFramesFromFile: Invalid or empty path");
			}
			else
			{
				Profiler.AddFramesFromFile_Internal(file, true);
			}
		}

		// Token: 0x06002241 RID: 8769 RVA: 0x00012361 File Offset: 0x00010561
		public static void AddFramesFromFile_Internal(string file, bool keepExistingFrames)
		{
			Profiler.AddFramesFromFile_InternalDelegateField(IL2CPP.ManagedStringToIl2Cpp(file), keepExistingFrames);
		}

		// Token: 0x06002242 RID: 8770 RVA: 0x00077DE0 File Offset: 0x00075FE0
		public static void BeginThreadProfiling(string threadGroupName, string threadName)
		{
			bool flag = String.IsNullOrEmpty(threadGroupName);
			if (flag)
			{
				throw new ArgumentException("Argument should be a valid string", "threadGroupName");
			}
			bool flag2 = String.IsNullOrEmpty(threadName);
			if (flag2)
			{
				throw new ArgumentException("Argument should be a valid string", "threadName");
			}
			Profiler.BeginThreadProfilingInternal(threadGroupName, threadName);
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x00012374 File Offset: 0x00010574
		public static void BeginThreadProfilingInternal(string threadGroupName, string threadName)
		{
			Profiler.BeginThreadProfilingInternalDelegateField(IL2CPP.ManagedStringToIl2Cpp(threadGroupName), IL2CPP.ManagedStringToIl2Cpp(threadName));
		}

		// Token: 0x06002244 RID: 8772 RVA: 0x0001238C File Offset: 0x0001058C
		public static void EndThreadProfiling()
		{
		}

		// Token: 0x06002245 RID: 8773 RVA: 0x0001238F File Offset: 0x0001058F
		public static void BeginSample(string name)
		{
			Profiler.ValidateArguments(name);
			Profiler.BeginSampleImpl(name, null);
		}

		// Token: 0x06002246 RID: 8774 RVA: 0x000123A1 File Offset: 0x000105A1
		public static void BeginSample(string name, Object targetObject)
		{
			Profiler.ValidateArguments(name);
			Profiler.BeginSampleImpl(name, targetObject);
		}

		// Token: 0x06002247 RID: 8775 RVA: 0x00077E2C File Offset: 0x0007602C
		public static void ValidateArguments(string name)
		{
			bool flag = String.IsNullOrEmpty(name);
			if (flag)
			{
				throw new ArgumentException("Argument should be a valid string.", "name");
			}
		}

		// Token: 0x06002248 RID: 8776 RVA: 0x000123B3 File Offset: 0x000105B3
		public static void BeginSampleImpl(string name, Object targetObject)
		{
			Profiler.BeginSampleImplDelegateField(IL2CPP.ManagedStringToIl2Cpp(name), IL2CPP.Il2CppObjectBaseToPtr(targetObject));
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x000123CB File Offset: 0x000105CB
		public static void EndSample()
		{
			Profiler.EndSampleDelegateField();
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x0600224A RID: 8778 RVA: 0x00077E58 File Offset: 0x00076058
		// (set) Token: 0x0600224B RID: 8779 RVA: 0x000123D7 File Offset: 0x000105D7
		public static int maxNumberOfSamplesPerFrame
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x0600224C RID: 8780 RVA: 0x00077E6C File Offset: 0x0007606C
		public static uint usedHeapSize
		{
			get
			{
				return (uint)Profiler.usedHeapSizeLong;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x0600224D RID: 8781 RVA: 0x000123DA File Offset: 0x000105DA
		public static long usedHeapSizeLong
		{
			get
			{
				return Profiler.get_usedHeapSizeLongDelegateField();
			}
		}

		// Token: 0x0600224E RID: 8782 RVA: 0x00077E84 File Offset: 0x00076084
		public static int GetRuntimeMemorySize(Object o)
		{
			return (int)Profiler.GetRuntimeMemorySizeLong(o);
		}

		// Token: 0x0600224F RID: 8783 RVA: 0x000123E6 File Offset: 0x000105E6
		public static long GetRuntimeMemorySizeLong(Object o)
		{
			return Profiler.GetRuntimeMemorySizeLongDelegateField(IL2CPP.Il2CppObjectBaseToPtr(o));
		}

		// Token: 0x06002250 RID: 8784 RVA: 0x00077EA0 File Offset: 0x000760A0
		public static uint GetMonoHeapSize()
		{
			return (uint)Profiler.GetMonoHeapSizeLong();
		}

		// Token: 0x06002251 RID: 8785 RVA: 0x000123F8 File Offset: 0x000105F8
		public static long GetMonoHeapSizeLong()
		{
			return Profiler.GetMonoHeapSizeLongDelegateField();
		}

		// Token: 0x06002252 RID: 8786 RVA: 0x00077EB8 File Offset: 0x000760B8
		public static uint GetMonoUsedSize()
		{
			return (uint)Profiler.GetMonoUsedSizeLong();
		}

		// Token: 0x06002253 RID: 8787 RVA: 0x00012404 File Offset: 0x00010604
		public static long GetMonoUsedSizeLong()
		{
			return Profiler.GetMonoUsedSizeLongDelegateField();
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x00012410 File Offset: 0x00010610
		public static bool SetTempAllocatorRequestedSize(uint size)
		{
			return Profiler.SetTempAllocatorRequestedSizeDelegateField(size);
		}

		// Token: 0x06002255 RID: 8789 RVA: 0x0001241D File Offset: 0x0001061D
		public static uint GetTempAllocatorSize()
		{
			return Profiler.GetTempAllocatorSizeDelegateField();
		}

		// Token: 0x06002256 RID: 8790 RVA: 0x00077ED0 File Offset: 0x000760D0
		public static uint GetTotalAllocatedMemory()
		{
			return (uint)Profiler.GetTotalAllocatedMemoryLong();
		}

		// Token: 0x06002257 RID: 8791 RVA: 0x00012429 File Offset: 0x00010629
		public static long GetTotalAllocatedMemoryLong()
		{
			return Profiler.GetTotalAllocatedMemoryLongDelegateField();
		}

		// Token: 0x06002258 RID: 8792 RVA: 0x00077EE8 File Offset: 0x000760E8
		public static uint GetTotalUnusedReservedMemory()
		{
			return (uint)Profiler.GetTotalUnusedReservedMemoryLong();
		}

		// Token: 0x06002259 RID: 8793 RVA: 0x00012435 File Offset: 0x00010635
		public static long GetTotalUnusedReservedMemoryLong()
		{
			return Profiler.GetTotalUnusedReservedMemoryLongDelegateField();
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x00077F00 File Offset: 0x00076100
		public static uint GetTotalReservedMemory()
		{
			return (uint)Profiler.GetTotalReservedMemoryLong();
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x00012441 File Offset: 0x00010641
		public static long GetTotalReservedMemoryLong()
		{
			return Profiler.GetTotalReservedMemoryLongDelegateField();
		}

		// Token: 0x0600225C RID: 8796 RVA: 0x00077F18 File Offset: 0x00076118
		public static long GetTotalFragmentationInfo(Unity.Collections.NativeArray<int> stats)
		{
			return Profiler.InternalGetTotalFragmentationInfo((IntPtr)Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.GetUnsafePtr<int>(stats), stats.Length);
		}

		// Token: 0x0600225D RID: 8797 RVA: 0x0001244D File Offset: 0x0001064D
		public static long InternalGetTotalFragmentationInfo(IntPtr pStats, int count)
		{
			return Profiler.InternalGetTotalFragmentationInfoDelegateField(pStats, count);
		}

		// Token: 0x0600225E RID: 8798 RVA: 0x0001245B File Offset: 0x0001065B
		public static long GetAllocatedMemoryForGraphicsDriver()
		{
			return Profiler.GetAllocatedMemoryForGraphicsDriverDelegateField();
		}

		// Token: 0x0600225F RID: 8799 RVA: 0x00077F44 File Offset: 0x00076144
		public unsafe static void EmitFrameMetaData(Guid id, int tag, Array data)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			Type elementType = data.GetType().GetElementType();
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsBlittable(elementType);
			if (flag2)
			{
				throw new ArgumentException(String.Format("{0} type must be blittable", elementType));
			}
			Profiler.Internal_EmitGlobalMetaData_Array((void*)(&id), 16, tag, data, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf(elementType), true);
		}

		// Token: 0x06002260 RID: 8800 RVA: 0x00077FAC File Offset: 0x000761AC
		public unsafe static void EmitFrameMetaData<T>(Guid id, int tag, List<T> data) where T : struct
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			Type typeFromHandle = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>());
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsBlittable(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
			if (flag2)
			{
				throw new ArgumentException(String.Format("{0} type must be blittable", typeFromHandle));
			}
			Profiler.Internal_EmitGlobalMetaData_Array((void*)(&id), 16, tag, NoAllocHelpers.ExtractArrayFromList(data), data.Count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf(typeFromHandle), true);
		}

		// Token: 0x06002261 RID: 8801 RVA: 0x00012467 File Offset: 0x00010667
		public unsafe static void EmitFrameMetaData<T>(Guid id, int tag, Unity.Collections.NativeArray<T> data) where T : struct
		{
			Profiler.Internal_EmitGlobalMetaData_Native((void*)(&id), 16, tag, (IntPtr)data.GetUnsafeReadOnlyPtr<T>(), data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), true);
		}

		// Token: 0x06002262 RID: 8802 RVA: 0x00078020 File Offset: 0x00076220
		public unsafe static void EmitSessionMetaData(Guid id, int tag, Array data)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			Type elementType = data.GetType().GetElementType();
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsBlittable(elementType);
			if (flag2)
			{
				throw new ArgumentException(String.Format("{0} type must be blittable", elementType));
			}
			Profiler.Internal_EmitGlobalMetaData_Array((void*)(&id), 16, tag, data, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf(elementType), false);
		}

		// Token: 0x06002263 RID: 8803 RVA: 0x00078088 File Offset: 0x00076288
		public unsafe static void EmitSessionMetaData<T>(Guid id, int tag, List<T> data) where T : struct
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			Type typeFromHandle = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>());
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsBlittable(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
			if (flag2)
			{
				throw new ArgumentException(String.Format("{0} type must be blittable", typeFromHandle));
			}
			Profiler.Internal_EmitGlobalMetaData_Array((void*)(&id), 16, tag, NoAllocHelpers.ExtractArrayFromList(data), data.Count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf(typeFromHandle), false);
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x0001248E File Offset: 0x0001068E
		public unsafe static void EmitSessionMetaData<T>(Guid id, int tag, Unity.Collections.NativeArray<T> data) where T : struct
		{
			Profiler.Internal_EmitGlobalMetaData_Native((void*)(&id), 16, tag, (IntPtr)data.GetUnsafeReadOnlyPtr<T>(), data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), false);
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x000124B5 File Offset: 0x000106B5
		public unsafe static void Internal_EmitGlobalMetaData_Array(void* id, int idLen, int tag, Array data, int count, int elementSize, bool frameData)
		{
			Profiler.Internal_EmitGlobalMetaData_ArrayDelegateField(id, idLen, tag, IL2CPP.Il2CppObjectBaseToPtr(data), count, elementSize, frameData);
		}

		// Token: 0x06002266 RID: 8806 RVA: 0x000124D0 File Offset: 0x000106D0
		public unsafe static void Internal_EmitGlobalMetaData_Native(void* id, int idLen, int tag, IntPtr data, int count, int elementSize, bool frameData)
		{
			Profiler.Internal_EmitGlobalMetaData_NativeDelegateField(id, idLen, tag, data, count, elementSize, frameData);
		}

		// Token: 0x04001C4A RID: 7242
		public const uint invalidProfilerArea = 4294967295U;

		// Token: 0x04001C4B RID: 7243
		private static readonly Profiler.get_supportedDelegate get_supportedDelegateField = IL2CPP.ResolveICall<Profiler.get_supportedDelegate>("UnityEngine.Profiling.Profiler::get_supported");

		// Token: 0x04001C4C RID: 7244
		private static readonly Profiler.get_logFileDelegate get_logFileDelegateField = IL2CPP.ResolveICall<Profiler.get_logFileDelegate>("UnityEngine.Profiling.Profiler::get_logFile");

		// Token: 0x04001C4D RID: 7245
		private static readonly Profiler.set_logFileDelegate set_logFileDelegateField = IL2CPP.ResolveICall<Profiler.set_logFileDelegate>("UnityEngine.Profiling.Profiler::set_logFile");

		// Token: 0x04001C4E RID: 7246
		private static readonly Profiler.get_enableBinaryLogDelegate get_enableBinaryLogDelegateField = IL2CPP.ResolveICall<Profiler.get_enableBinaryLogDelegate>("UnityEngine.Profiling.Profiler::get_enableBinaryLog");

		// Token: 0x04001C4F RID: 7247
		private static readonly Profiler.set_enableBinaryLogDelegate set_enableBinaryLogDelegateField = IL2CPP.ResolveICall<Profiler.set_enableBinaryLogDelegate>("UnityEngine.Profiling.Profiler::set_enableBinaryLog");

		// Token: 0x04001C50 RID: 7248
		private static readonly Profiler.get_maxUsedMemoryDelegate get_maxUsedMemoryDelegateField = IL2CPP.ResolveICall<Profiler.get_maxUsedMemoryDelegate>("UnityEngine.Profiling.Profiler::get_maxUsedMemory");

		// Token: 0x04001C51 RID: 7249
		private static readonly Profiler.set_maxUsedMemoryDelegate set_maxUsedMemoryDelegateField = IL2CPP.ResolveICall<Profiler.set_maxUsedMemoryDelegate>("UnityEngine.Profiling.Profiler::set_maxUsedMemory");

		// Token: 0x04001C52 RID: 7250
		private static readonly Profiler.get_enabledDelegate get_enabledDelegateField = IL2CPP.ResolveICall<Profiler.get_enabledDelegate>("UnityEngine.Profiling.Profiler::get_enabled");

		// Token: 0x04001C53 RID: 7251
		private static readonly Profiler.set_enabledDelegate set_enabledDelegateField = IL2CPP.ResolveICall<Profiler.set_enabledDelegate>("UnityEngine.Profiling.Profiler::set_enabled");

		// Token: 0x04001C54 RID: 7252
		private static readonly Profiler.get_enableAllocationCallstacksDelegate get_enableAllocationCallstacksDelegateField = IL2CPP.ResolveICall<Profiler.get_enableAllocationCallstacksDelegate>("UnityEngine.Profiling.Profiler::get_enableAllocationCallstacks");

		// Token: 0x04001C55 RID: 7253
		private static readonly Profiler.set_enableAllocationCallstacksDelegate set_enableAllocationCallstacksDelegateField = IL2CPP.ResolveICall<Profiler.set_enableAllocationCallstacksDelegate>("UnityEngine.Profiling.Profiler::set_enableAllocationCallstacks");

		// Token: 0x04001C56 RID: 7254
		private static readonly Profiler.SetAreaEnabledDelegate SetAreaEnabledDelegateField = IL2CPP.ResolveICall<Profiler.SetAreaEnabledDelegate>("UnityEngine.Profiling.Profiler::SetAreaEnabled");

		// Token: 0x04001C57 RID: 7255
		private static readonly Profiler.GetAreaEnabledDelegate GetAreaEnabledDelegateField = IL2CPP.ResolveICall<Profiler.GetAreaEnabledDelegate>("UnityEngine.Profiling.Profiler::GetAreaEnabled");

		// Token: 0x04001C58 RID: 7256
		private static readonly Profiler.AddFramesFromFile_InternalDelegate AddFramesFromFile_InternalDelegateField = IL2CPP.ResolveICall<Profiler.AddFramesFromFile_InternalDelegate>("UnityEngine.Profiling.Profiler::AddFramesFromFile_Internal");

		// Token: 0x04001C59 RID: 7257
		private static readonly Profiler.BeginThreadProfilingInternalDelegate BeginThreadProfilingInternalDelegateField = IL2CPP.ResolveICall<Profiler.BeginThreadProfilingInternalDelegate>("UnityEngine.Profiling.Profiler::BeginThreadProfilingInternal");

		// Token: 0x04001C5A RID: 7258
		private static readonly Profiler.BeginSampleImplDelegate BeginSampleImplDelegateField = IL2CPP.ResolveICall<Profiler.BeginSampleImplDelegate>("UnityEngine.Profiling.Profiler::BeginSampleImpl");

		// Token: 0x04001C5B RID: 7259
		private static readonly Profiler.EndSampleDelegate EndSampleDelegateField = IL2CPP.ResolveICall<Profiler.EndSampleDelegate>("UnityEngine.Profiling.Profiler::EndSample");

		// Token: 0x04001C5C RID: 7260
		private static readonly Profiler.get_usedHeapSizeLongDelegate get_usedHeapSizeLongDelegateField = IL2CPP.ResolveICall<Profiler.get_usedHeapSizeLongDelegate>("UnityEngine.Profiling.Profiler::get_usedHeapSizeLong");

		// Token: 0x04001C5D RID: 7261
		private static readonly Profiler.GetRuntimeMemorySizeLongDelegate GetRuntimeMemorySizeLongDelegateField = IL2CPP.ResolveICall<Profiler.GetRuntimeMemorySizeLongDelegate>("UnityEngine.Profiling.Profiler::GetRuntimeMemorySizeLong");

		// Token: 0x04001C5E RID: 7262
		private static readonly Profiler.GetMonoHeapSizeLongDelegate GetMonoHeapSizeLongDelegateField = IL2CPP.ResolveICall<Profiler.GetMonoHeapSizeLongDelegate>("UnityEngine.Profiling.Profiler::GetMonoHeapSizeLong");

		// Token: 0x04001C5F RID: 7263
		private static readonly Profiler.GetMonoUsedSizeLongDelegate GetMonoUsedSizeLongDelegateField = IL2CPP.ResolveICall<Profiler.GetMonoUsedSizeLongDelegate>("UnityEngine.Profiling.Profiler::GetMonoUsedSizeLong");

		// Token: 0x04001C60 RID: 7264
		private static readonly Profiler.SetTempAllocatorRequestedSizeDelegate SetTempAllocatorRequestedSizeDelegateField = IL2CPP.ResolveICall<Profiler.SetTempAllocatorRequestedSizeDelegate>("UnityEngine.Profiling.Profiler::SetTempAllocatorRequestedSize");

		// Token: 0x04001C61 RID: 7265
		private static readonly Profiler.GetTempAllocatorSizeDelegate GetTempAllocatorSizeDelegateField = IL2CPP.ResolveICall<Profiler.GetTempAllocatorSizeDelegate>("UnityEngine.Profiling.Profiler::GetTempAllocatorSize");

		// Token: 0x04001C62 RID: 7266
		private static readonly Profiler.GetTotalAllocatedMemoryLongDelegate GetTotalAllocatedMemoryLongDelegateField = IL2CPP.ResolveICall<Profiler.GetTotalAllocatedMemoryLongDelegate>("UnityEngine.Profiling.Profiler::GetTotalAllocatedMemoryLong");

		// Token: 0x04001C63 RID: 7267
		private static readonly Profiler.GetTotalUnusedReservedMemoryLongDelegate GetTotalUnusedReservedMemoryLongDelegateField = IL2CPP.ResolveICall<Profiler.GetTotalUnusedReservedMemoryLongDelegate>("UnityEngine.Profiling.Profiler::GetTotalUnusedReservedMemoryLong");

		// Token: 0x04001C64 RID: 7268
		private static readonly Profiler.GetTotalReservedMemoryLongDelegate GetTotalReservedMemoryLongDelegateField = IL2CPP.ResolveICall<Profiler.GetTotalReservedMemoryLongDelegate>("UnityEngine.Profiling.Profiler::GetTotalReservedMemoryLong");

		// Token: 0x04001C65 RID: 7269
		private static readonly Profiler.InternalGetTotalFragmentationInfoDelegate InternalGetTotalFragmentationInfoDelegateField = IL2CPP.ResolveICall<Profiler.InternalGetTotalFragmentationInfoDelegate>("UnityEngine.Profiling.Profiler::InternalGetTotalFragmentationInfo");

		// Token: 0x04001C66 RID: 7270
		private static readonly Profiler.GetAllocatedMemoryForGraphicsDriverDelegate GetAllocatedMemoryForGraphicsDriverDelegateField = IL2CPP.ResolveICall<Profiler.GetAllocatedMemoryForGraphicsDriverDelegate>("UnityEngine.Profiling.Profiler::GetAllocatedMemoryForGraphicsDriver");

		// Token: 0x04001C67 RID: 7271
		private static readonly Profiler.Internal_EmitGlobalMetaData_ArrayDelegate Internal_EmitGlobalMetaData_ArrayDelegateField = IL2CPP.ResolveICall<Profiler.Internal_EmitGlobalMetaData_ArrayDelegate>("UnityEngine.Profiling.Profiler::Internal_EmitGlobalMetaData_Array");

		// Token: 0x04001C68 RID: 7272
		private static readonly Profiler.Internal_EmitGlobalMetaData_NativeDelegate Internal_EmitGlobalMetaData_NativeDelegateField = IL2CPP.ResolveICall<Profiler.Internal_EmitGlobalMetaData_NativeDelegate>("UnityEngine.Profiling.Profiler::Internal_EmitGlobalMetaData_Native");

		// Token: 0x02000BAF RID: 2991
		// (Invoke) Token: 0x060035B8 RID: 13752
		private delegate bool get_supportedDelegate();

		// Token: 0x02000BB0 RID: 2992
		// (Invoke) Token: 0x060035BA RID: 13754
		private delegate IntPtr get_logFileDelegate();

		// Token: 0x02000BB1 RID: 2993
		// (Invoke) Token: 0x060035BC RID: 13756
		private delegate void set_logFileDelegate(IntPtr value);

		// Token: 0x02000BB2 RID: 2994
		// (Invoke) Token: 0x060035BE RID: 13758
		private delegate bool get_enableBinaryLogDelegate();

		// Token: 0x02000BB3 RID: 2995
		// (Invoke) Token: 0x060035C0 RID: 13760
		private delegate void set_enableBinaryLogDelegate(bool value);

		// Token: 0x02000BB4 RID: 2996
		// (Invoke) Token: 0x060035C2 RID: 13762
		private delegate int get_maxUsedMemoryDelegate();

		// Token: 0x02000BB5 RID: 2997
		// (Invoke) Token: 0x060035C4 RID: 13764
		private delegate void set_maxUsedMemoryDelegate(int value);

		// Token: 0x02000BB6 RID: 2998
		// (Invoke) Token: 0x060035C6 RID: 13766
		private delegate bool get_enabledDelegate();

		// Token: 0x02000BB7 RID: 2999
		// (Invoke) Token: 0x060035C8 RID: 13768
		private delegate void set_enabledDelegate(bool value);

		// Token: 0x02000BB8 RID: 3000
		// (Invoke) Token: 0x060035CA RID: 13770
		private delegate bool get_enableAllocationCallstacksDelegate();

		// Token: 0x02000BB9 RID: 3001
		// (Invoke) Token: 0x060035CC RID: 13772
		private delegate void set_enableAllocationCallstacksDelegate(bool value);

		// Token: 0x02000BBA RID: 3002
		// (Invoke) Token: 0x060035CE RID: 13774
		private delegate void SetAreaEnabledDelegate(ProfilerArea area, bool enabled);

		// Token: 0x02000BBB RID: 3003
		// (Invoke) Token: 0x060035D0 RID: 13776
		private delegate bool GetAreaEnabledDelegate(ProfilerArea area);

		// Token: 0x02000BBC RID: 3004
		// (Invoke) Token: 0x060035D2 RID: 13778
		private delegate void AddFramesFromFile_InternalDelegate(IntPtr file, bool keepExistingFrames);

		// Token: 0x02000BBD RID: 3005
		// (Invoke) Token: 0x060035D4 RID: 13780
		private delegate void BeginThreadProfilingInternalDelegate(IntPtr threadGroupName, IntPtr threadName);

		// Token: 0x02000BBE RID: 3006
		// (Invoke) Token: 0x060035D6 RID: 13782
		private delegate void BeginSampleImplDelegate(IntPtr name, IntPtr targetObject);

		// Token: 0x02000BBF RID: 3007
		// (Invoke) Token: 0x060035D8 RID: 13784
		private delegate void EndSampleDelegate();

		// Token: 0x02000BC0 RID: 3008
		// (Invoke) Token: 0x060035DA RID: 13786
		private delegate long get_usedHeapSizeLongDelegate();

		// Token: 0x02000BC1 RID: 3009
		// (Invoke) Token: 0x060035DC RID: 13788
		private delegate long GetRuntimeMemorySizeLongDelegate(IntPtr o);

		// Token: 0x02000BC2 RID: 3010
		// (Invoke) Token: 0x060035DE RID: 13790
		private delegate long GetMonoHeapSizeLongDelegate();

		// Token: 0x02000BC3 RID: 3011
		// (Invoke) Token: 0x060035E0 RID: 13792
		private delegate long GetMonoUsedSizeLongDelegate();

		// Token: 0x02000BC4 RID: 3012
		// (Invoke) Token: 0x060035E2 RID: 13794
		private delegate bool SetTempAllocatorRequestedSizeDelegate(uint size);

		// Token: 0x02000BC5 RID: 3013
		// (Invoke) Token: 0x060035E4 RID: 13796
		private delegate uint GetTempAllocatorSizeDelegate();

		// Token: 0x02000BC6 RID: 3014
		// (Invoke) Token: 0x060035E6 RID: 13798
		private delegate long GetTotalAllocatedMemoryLongDelegate();

		// Token: 0x02000BC7 RID: 3015
		// (Invoke) Token: 0x060035E8 RID: 13800
		private delegate long GetTotalUnusedReservedMemoryLongDelegate();

		// Token: 0x02000BC8 RID: 3016
		// (Invoke) Token: 0x060035EA RID: 13802
		private delegate long GetTotalReservedMemoryLongDelegate();

		// Token: 0x02000BC9 RID: 3017
		// (Invoke) Token: 0x060035EC RID: 13804
		private delegate long InternalGetTotalFragmentationInfoDelegate(IntPtr pStats, int count);

		// Token: 0x02000BCA RID: 3018
		// (Invoke) Token: 0x060035EE RID: 13806
		private delegate long GetAllocatedMemoryForGraphicsDriverDelegate();

		// Token: 0x02000BCB RID: 3019
		// (Invoke) Token: 0x060035F0 RID: 13808
		private delegate void Internal_EmitGlobalMetaData_ArrayDelegate(IntPtr id, int idLen, int tag, IntPtr data, int count, int elementSize, bool frameData);

		// Token: 0x02000BCC RID: 3020
		// (Invoke) Token: 0x060035F2 RID: 13810
		private delegate void Internal_EmitGlobalMetaData_NativeDelegate(IntPtr id, int idLen, int tag, IntPtr data, int count, int elementSize, bool frameData);
	}
}
