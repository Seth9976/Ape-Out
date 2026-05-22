using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Timers
{
	// Token: 0x02000189 RID: 393
	[StructLayout(2)]
	public struct Time
	{
		// Token: 0x060011CF RID: 4559 RVA: 0x000556A0 File Offset: 0x000538A0
		// Note: this type is marked as 'beforefieldinit'.
		static Time()
		{
			Il2CppClassPointerStore<Time>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Timers", "Time");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Time>.NativeClassPtr);
			Time.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Time>.NativeClassPtr, "type");
			Time.NativeFieldInfoPtr_milliseconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Time>.NativeClassPtr, "milliseconds");
			Time.NativeFieldInfoPtr_samples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Time>.NativeClassPtr, "samples");
			Time.NativeFieldInfoPtr_byteCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Time>.NativeClassPtr, "byteCount");
			Time.NativeFieldInfoPtr_ticks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Time>.NativeClassPtr, "ticks");
			Time.NativeFieldInfoPtr_hours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Time>.NativeClassPtr, "hours");
			Time.NativeFieldInfoPtr_minutes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Time>.NativeClassPtr, "minutes");
			Time.NativeFieldInfoPtr_seconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Time>.NativeClassPtr, "seconds");
			Time.NativeFieldInfoPtr_frames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Time>.NativeClassPtr, "frames");
			Time.NativeFieldInfoPtr_framesPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Time>.NativeClassPtr, "framesPerSecond");
			Time.NativeFieldInfoPtr_dummy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Time>.NativeClassPtr, "dummy");
			Time.NativeFieldInfoPtr_pad1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Time>.NativeClassPtr, "pad1");
			Time.NativeFieldInfoPtr_pad2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Time>.NativeClassPtr, "pad2");
			Time.NativeFieldInfoPtr_songPositionPointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Time>.NativeClassPtr, "songPositionPointer");
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x000074E1 File Offset: 0x000056E1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Time>.NativeClassPtr, ref this));
		}

		// Token: 0x040013D2 RID: 5074
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x040013D3 RID: 5075
		private static readonly IntPtr NativeFieldInfoPtr_milliseconds;

		// Token: 0x040013D4 RID: 5076
		private static readonly IntPtr NativeFieldInfoPtr_samples;

		// Token: 0x040013D5 RID: 5077
		private static readonly IntPtr NativeFieldInfoPtr_byteCount;

		// Token: 0x040013D6 RID: 5078
		private static readonly IntPtr NativeFieldInfoPtr_ticks;

		// Token: 0x040013D7 RID: 5079
		private static readonly IntPtr NativeFieldInfoPtr_hours;

		// Token: 0x040013D8 RID: 5080
		private static readonly IntPtr NativeFieldInfoPtr_minutes;

		// Token: 0x040013D9 RID: 5081
		private static readonly IntPtr NativeFieldInfoPtr_seconds;

		// Token: 0x040013DA RID: 5082
		private static readonly IntPtr NativeFieldInfoPtr_frames;

		// Token: 0x040013DB RID: 5083
		private static readonly IntPtr NativeFieldInfoPtr_framesPerSecond;

		// Token: 0x040013DC RID: 5084
		private static readonly IntPtr NativeFieldInfoPtr_dummy;

		// Token: 0x040013DD RID: 5085
		private static readonly IntPtr NativeFieldInfoPtr_pad1;

		// Token: 0x040013DE RID: 5086
		private static readonly IntPtr NativeFieldInfoPtr_pad2;

		// Token: 0x040013DF RID: 5087
		private static readonly IntPtr NativeFieldInfoPtr_songPositionPointer;

		// Token: 0x040013E0 RID: 5088
		[FieldOffset(0)]
		public int type;

		// Token: 0x040013E1 RID: 5089
		[FieldOffset(4)]
		public int milliseconds;

		// Token: 0x040013E2 RID: 5090
		[FieldOffset(4)]
		public int samples;

		// Token: 0x040013E3 RID: 5091
		[FieldOffset(4)]
		public int byteCount;

		// Token: 0x040013E4 RID: 5092
		[FieldOffset(4)]
		public int ticks;

		// Token: 0x040013E5 RID: 5093
		[FieldOffset(4)]
		public byte hours;

		// Token: 0x040013E6 RID: 5094
		[FieldOffset(5)]
		public byte minutes;

		// Token: 0x040013E7 RID: 5095
		[FieldOffset(6)]
		public byte seconds;

		// Token: 0x040013E8 RID: 5096
		[FieldOffset(7)]
		public byte frames;

		// Token: 0x040013E9 RID: 5097
		[FieldOffset(8)]
		public byte framesPerSecond;

		// Token: 0x040013EA RID: 5098
		[FieldOffset(9)]
		public byte dummy;

		// Token: 0x040013EB RID: 5099
		[FieldOffset(10)]
		public byte pad1;

		// Token: 0x040013EC RID: 5100
		[FieldOffset(11)]
		public byte pad2;

		// Token: 0x040013ED RID: 5101
		[FieldOffset(4)]
		public int songPositionPointer;
	}
}
