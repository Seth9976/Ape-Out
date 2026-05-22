using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.IO.LowLevel.Unsafe
{
	// Token: 0x0200001D RID: 29
	public class AsyncReadManagerMetricsFilters : Object
	{
		// Token: 0x060000C6 RID: 198 RVA: 0x00016FCC File Offset: 0x000151CC
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncReadManagerMetricsFilters()
		{
			Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.LowLevel.Unsafe", "AsyncReadManagerMetricsFilters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr);
			AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_TypeIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr, "TypeIDs");
			AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_States = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr, "States");
			AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_ReadTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr, "ReadTypes");
			AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_PriorityLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr, "PriorityLevels");
			AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_Subsystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr, "Subsystems");
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002849 File Offset: 0x00000A49
		public AsyncReadManagerMetricsFilters(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00017060 File Offset: 0x00015260
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00002852 File Offset: 0x00000A52
		public unsafe Il2CppStructArray<ulong> TypeIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_TypeIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_TypeIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00017090 File Offset: 0x00015290
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00002871 File Offset: 0x00000A71
		public unsafe Il2CppStructArray<ProcessingState> States
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_States);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ProcessingState>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_States), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000CC RID: 204 RVA: 0x000170C0 File Offset: 0x000152C0
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00002890 File Offset: 0x00000A90
		public unsafe Il2CppStructArray<FileReadType> ReadTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_ReadTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<FileReadType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_ReadTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000CE RID: 206 RVA: 0x000170F0 File Offset: 0x000152F0
		// (set) Token: 0x060000CF RID: 207 RVA: 0x000028AF File Offset: 0x00000AAF
		public unsafe Il2CppStructArray<Priority> PriorityLevels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_PriorityLevels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Priority>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_PriorityLevels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00017120 File Offset: 0x00015320
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x000028CE File Offset: 0x00000ACE
		public unsafe Il2CppStructArray<AssetLoadingSubsystem> Subsystems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_Subsystems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<AssetLoadingSubsystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_Subsystems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000028ED File Offset: 0x00000AED
		public void SetTypeIDFilter(Il2CppStructArray<ulong> _typeIDs)
		{
			this.TypeIDs = _typeIDs;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000028F7 File Offset: 0x00000AF7
		public void SetStateFilter(Il2CppStructArray<ProcessingState> _states)
		{
			this.States = _states;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002901 File Offset: 0x00000B01
		public void SetReadTypeFilter(Il2CppStructArray<FileReadType> _readTypes)
		{
			this.ReadTypes = _readTypes;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000290B File Offset: 0x00000B0B
		public void SetPriorityFilter(Il2CppStructArray<Priority> _priorityLevels)
		{
			this.PriorityLevels = _priorityLevels;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002915 File Offset: 0x00000B15
		public void SetSubsystemFilter(Il2CppStructArray<AssetLoadingSubsystem> _subsystems)
		{
			this.Subsystems = _subsystems;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000291F File Offset: 0x00000B1F
		public void SetTypeIDFilter(ulong _typeID)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000292C File Offset: 0x00000B2C
		public void SetStateFilter(ProcessingState _state)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002939 File Offset: 0x00000B39
		public void SetReadTypeFilter(FileReadType _readType)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002946 File Offset: 0x00000B46
		public void SetPriorityFilter(Priority _priorityLevel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002953 File Offset: 0x00000B53
		public void SetSubsystemFilter(AssetLoadingSubsystem _subsystem)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002960 File Offset: 0x00000B60
		public void RemoveTypeIDFilter()
		{
			this.TypeIDs = null;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000296A File Offset: 0x00000B6A
		public void RemoveStateFilter()
		{
			this.States = null;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002974 File Offset: 0x00000B74
		public void RemoveReadTypeFilter()
		{
			this.ReadTypes = null;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000297E File Offset: 0x00000B7E
		public void RemovePriorityFilter()
		{
			this.PriorityLevels = null;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002988 File Offset: 0x00000B88
		public void RemoveSubsystemFilter()
		{
			this.Subsystems = null;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002992 File Offset: 0x00000B92
		public void ClearFilters()
		{
			this.RemoveTypeIDFilter();
			this.RemoveStateFilter();
			this.RemoveReadTypeFilter();
			this.RemovePriorityFilter();
			this.RemoveSubsystemFilter();
		}

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeFieldInfoPtr_TypeIDs;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeFieldInfoPtr_States;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeFieldInfoPtr_ReadTypes;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeFieldInfoPtr_PriorityLevels;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeFieldInfoPtr_Subsystems;
	}
}
