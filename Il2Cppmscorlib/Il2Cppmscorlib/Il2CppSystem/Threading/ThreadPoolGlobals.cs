using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000285 RID: 645
	public static class ThreadPoolGlobals : Object
	{
		// Token: 0x06002C76 RID: 11382 RVA: 0x000E5B4C File Offset: 0x000E3D4C
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadPoolGlobals()
		{
			Il2CppClassPointerStore<ThreadPoolGlobals>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ThreadPoolGlobals");
			ThreadPoolGlobals.NativeFieldInfoPtr_tpQuantum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolGlobals>.NativeClassPtr, "tpQuantum");
			ThreadPoolGlobals.NativeFieldInfoPtr_processorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolGlobals>.NativeClassPtr, "processorCount");
			ThreadPoolGlobals.NativeFieldInfoPtr_tpHosted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolGlobals>.NativeClassPtr, "tpHosted");
			ThreadPoolGlobals.NativeFieldInfoPtr_vmTpInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolGlobals>.NativeClassPtr, "vmTpInitialized");
			ThreadPoolGlobals.NativeFieldInfoPtr_enableWorkerTracking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolGlobals>.NativeClassPtr, "enableWorkerTracking");
			ThreadPoolGlobals.NativeFieldInfoPtr_workQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolGlobals>.NativeClassPtr, "workQueue");
		}

		// Token: 0x06002C77 RID: 11383 RVA: 0x0000F4D1 File Offset: 0x0000D6D1
		public ThreadPoolGlobals(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06002C78 RID: 11384 RVA: 0x000E5BEC File Offset: 0x000E3DEC
		// (set) Token: 0x06002C79 RID: 11385 RVA: 0x0000F4DA File Offset: 0x0000D6DA
		public unsafe static uint tpQuantum
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(ThreadPoolGlobals.NativeFieldInfoPtr_tpQuantum, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreadPoolGlobals.NativeFieldInfoPtr_tpQuantum, (void*)(&value));
			}
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06002C7A RID: 11386 RVA: 0x000E5C08 File Offset: 0x000E3E08
		// (set) Token: 0x06002C7B RID: 11387 RVA: 0x0000F4E8 File Offset: 0x0000D6E8
		public unsafe static int processorCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ThreadPoolGlobals.NativeFieldInfoPtr_processorCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreadPoolGlobals.NativeFieldInfoPtr_processorCount, (void*)(&value));
			}
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06002C7C RID: 11388 RVA: 0x000E5C24 File Offset: 0x000E3E24
		// (set) Token: 0x06002C7D RID: 11389 RVA: 0x0000F4F6 File Offset: 0x0000D6F6
		public unsafe static bool tpHosted
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ThreadPoolGlobals.NativeFieldInfoPtr_tpHosted, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreadPoolGlobals.NativeFieldInfoPtr_tpHosted, (void*)(&value));
			}
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x06002C7E RID: 11390 RVA: 0x000E5C40 File Offset: 0x000E3E40
		// (set) Token: 0x06002C7F RID: 11391 RVA: 0x0000F504 File Offset: 0x0000D704
		public unsafe static bool vmTpInitialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ThreadPoolGlobals.NativeFieldInfoPtr_vmTpInitialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreadPoolGlobals.NativeFieldInfoPtr_vmTpInitialized, (void*)(&value));
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06002C80 RID: 11392 RVA: 0x000E5C5C File Offset: 0x000E3E5C
		// (set) Token: 0x06002C81 RID: 11393 RVA: 0x0000F512 File Offset: 0x0000D712
		public unsafe static bool enableWorkerTracking
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ThreadPoolGlobals.NativeFieldInfoPtr_enableWorkerTracking, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreadPoolGlobals.NativeFieldInfoPtr_enableWorkerTracking, (void*)(&value));
			}
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06002C82 RID: 11394 RVA: 0x000E5C78 File Offset: 0x000E3E78
		// (set) Token: 0x06002C83 RID: 11395 RVA: 0x0000F520 File Offset: 0x0000D720
		public unsafe static ThreadPoolWorkQueue workQueue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ThreadPoolGlobals.NativeFieldInfoPtr_workQueue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadPoolWorkQueue>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreadPoolGlobals.NativeFieldInfoPtr_workQueue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040026C1 RID: 9921
		private static readonly IntPtr NativeFieldInfoPtr_tpQuantum;

		// Token: 0x040026C2 RID: 9922
		private static readonly IntPtr NativeFieldInfoPtr_processorCount;

		// Token: 0x040026C3 RID: 9923
		private static readonly IntPtr NativeFieldInfoPtr_tpHosted;

		// Token: 0x040026C4 RID: 9924
		private static readonly IntPtr NativeFieldInfoPtr_vmTpInitialized;

		// Token: 0x040026C5 RID: 9925
		private static readonly IntPtr NativeFieldInfoPtr_enableWorkerTracking;

		// Token: 0x040026C6 RID: 9926
		private static readonly IntPtr NativeFieldInfoPtr_workQueue;
	}
}
