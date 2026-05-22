using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000118 RID: 280
	public sealed class RangePositionInfo : ValueType
	{
		// Token: 0x060016BA RID: 5818 RVA: 0x00073D5C File Offset: 0x00071F5C
		// Note: this type is marked as 'beforefieldinit'.
		static RangePositionInfo()
		{
			Il2CppClassPointerStore<RangePositionInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "RangePositionInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RangePositionInfo>.NativeClassPtr);
			RangePositionInfo.NativeFieldInfoPtr_curpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangePositionInfo>.NativeClassPtr, "curpos");
			RangePositionInfo.NativeFieldInfoPtr_rangeCounters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangePositionInfo>.NativeClassPtr, "rangeCounters");
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x0000A11C File Offset: 0x0000831C
		public RangePositionInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x0000A125 File Offset: 0x00008325
		public RangePositionInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RangePositionInfo>.NativeClassPtr))
		{
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x060016BD RID: 5821 RVA: 0x00073DB4 File Offset: 0x00071FB4
		// (set) Token: 0x060016BE RID: 5822 RVA: 0x0000A137 File Offset: 0x00008337
		public unsafe BitSet curpos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangePositionInfo.NativeFieldInfoPtr_curpos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BitSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangePositionInfo.NativeFieldInfoPtr_curpos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x060016BF RID: 5823 RVA: 0x00073DE4 File Offset: 0x00071FE4
		// (set) Token: 0x060016C0 RID: 5824 RVA: 0x0000A156 File Offset: 0x00008356
		public unsafe Il2CppStructArray<Decimal> rangeCounters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangePositionInfo.NativeFieldInfoPtr_rangeCounters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Decimal>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangePositionInfo.NativeFieldInfoPtr_rangeCounters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001146 RID: 4422
		private static readonly IntPtr NativeFieldInfoPtr_curpos;

		// Token: 0x04001147 RID: 4423
		private static readonly IntPtr NativeFieldInfoPtr_rangeCounters;
	}
}
