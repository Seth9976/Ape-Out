using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x02000196 RID: 406
	public sealed class MidiInCaps : ValueType
	{
		// Token: 0x06001314 RID: 4884 RVA: 0x0005A1F4 File Offset: 0x000583F4
		// Note: this type is marked as 'beforefieldinit'.
		static MidiInCaps()
		{
			Il2CppClassPointerStore<MidiInCaps>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "MidiInCaps");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MidiInCaps>.NativeClassPtr);
			MidiInCaps.NativeFieldInfoPtr_mid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiInCaps>.NativeClassPtr, "mid");
			MidiInCaps.NativeFieldInfoPtr_pid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiInCaps>.NativeClassPtr, "pid");
			MidiInCaps.NativeFieldInfoPtr_driverVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiInCaps>.NativeClassPtr, "driverVersion");
			MidiInCaps.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiInCaps>.NativeClassPtr, "name");
			MidiInCaps.NativeFieldInfoPtr_support = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiInCaps>.NativeClassPtr, "support");
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x00007CF8 File Offset: 0x00005EF8
		public MidiInCaps(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x00007D01 File Offset: 0x00005F01
		public MidiInCaps()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MidiInCaps>.NativeClassPtr))
		{
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06001317 RID: 4887 RVA: 0x0005A288 File Offset: 0x00058488
		// (set) Token: 0x06001318 RID: 4888 RVA: 0x00007D13 File Offset: 0x00005F13
		public unsafe short mid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiInCaps.NativeFieldInfoPtr_mid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiInCaps.NativeFieldInfoPtr_mid)) = value;
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06001319 RID: 4889 RVA: 0x0005A2B0 File Offset: 0x000584B0
		// (set) Token: 0x0600131A RID: 4890 RVA: 0x00007D2E File Offset: 0x00005F2E
		public unsafe short pid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiInCaps.NativeFieldInfoPtr_pid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiInCaps.NativeFieldInfoPtr_pid)) = value;
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x0600131B RID: 4891 RVA: 0x0005A2D8 File Offset: 0x000584D8
		// (set) Token: 0x0600131C RID: 4892 RVA: 0x00007D49 File Offset: 0x00005F49
		public unsafe int driverVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiInCaps.NativeFieldInfoPtr_driverVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiInCaps.NativeFieldInfoPtr_driverVersion)) = value;
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x0600131D RID: 4893 RVA: 0x0005A300 File Offset: 0x00058500
		// (set) Token: 0x0600131E RID: 4894 RVA: 0x00007D64 File Offset: 0x00005F64
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiInCaps.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiInCaps.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x0600131F RID: 4895 RVA: 0x0005A328 File Offset: 0x00058528
		// (set) Token: 0x06001320 RID: 4896 RVA: 0x00007D83 File Offset: 0x00005F83
		public unsafe int support
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiInCaps.NativeFieldInfoPtr_support);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiInCaps.NativeFieldInfoPtr_support)) = value;
			}
		}

		// Token: 0x040014DD RID: 5341
		private static readonly IntPtr NativeFieldInfoPtr_mid;

		// Token: 0x040014DE RID: 5342
		private static readonly IntPtr NativeFieldInfoPtr_pid;

		// Token: 0x040014DF RID: 5343
		private static readonly IntPtr NativeFieldInfoPtr_driverVersion;

		// Token: 0x040014E0 RID: 5344
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040014E1 RID: 5345
		private static readonly IntPtr NativeFieldInfoPtr_support;
	}
}
