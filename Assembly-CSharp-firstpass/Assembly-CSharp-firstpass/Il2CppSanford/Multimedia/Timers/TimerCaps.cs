using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Timers
{
	// Token: 0x0200018B RID: 395
	[StructLayout(2)]
	public struct TimerCaps
	{
		// Token: 0x060011D1 RID: 4561 RVA: 0x000557E8 File Offset: 0x000539E8
		// Note: this type is marked as 'beforefieldinit'.
		static TimerCaps()
		{
			Il2CppClassPointerStore<TimerCaps>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Timers", "TimerCaps");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimerCaps>.NativeClassPtr);
			TimerCaps.NativeFieldInfoPtr_periodMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerCaps>.NativeClassPtr, "periodMin");
			TimerCaps.NativeFieldInfoPtr_periodMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerCaps>.NativeClassPtr, "periodMax");
			TimerCaps.NativeMethodInfoPtr_get_Default_Public_Static_get_TimerCaps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerCaps>.NativeClassPtr, 100665868);
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x060011D2 RID: 4562 RVA: 0x00055854 File Offset: 0x00053A54
		public unsafe static TimerCaps Default
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerCaps.NativeMethodInfoPtr_get_Default_Public_Static_get_TimerCaps_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x000074F3 File Offset: 0x000056F3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimerCaps>.NativeClassPtr, ref this));
		}

		// Token: 0x040013F1 RID: 5105
		private static readonly IntPtr NativeFieldInfoPtr_periodMin;

		// Token: 0x040013F2 RID: 5106
		private static readonly IntPtr NativeFieldInfoPtr_periodMax;

		// Token: 0x040013F3 RID: 5107
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_TimerCaps_0;

		// Token: 0x040013F4 RID: 5108
		[FieldOffset(0)]
		public int periodMin;

		// Token: 0x040013F5 RID: 5109
		[FieldOffset(4)]
		public int periodMax;
	}
}
