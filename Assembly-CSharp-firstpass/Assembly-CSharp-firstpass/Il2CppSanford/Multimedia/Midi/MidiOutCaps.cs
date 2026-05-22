using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x0200019B RID: 411
	public sealed class MidiOutCaps : ValueType
	{
		// Token: 0x06001367 RID: 4967 RVA: 0x0005AE1C File Offset: 0x0005901C
		// Note: this type is marked as 'beforefieldinit'.
		static MidiOutCaps()
		{
			Il2CppClassPointerStore<MidiOutCaps>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "MidiOutCaps");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MidiOutCaps>.NativeClassPtr);
			MidiOutCaps.NativeFieldInfoPtr_mid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiOutCaps>.NativeClassPtr, "mid");
			MidiOutCaps.NativeFieldInfoPtr_pid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiOutCaps>.NativeClassPtr, "pid");
			MidiOutCaps.NativeFieldInfoPtr_driverVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiOutCaps>.NativeClassPtr, "driverVersion");
			MidiOutCaps.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiOutCaps>.NativeClassPtr, "name");
			MidiOutCaps.NativeFieldInfoPtr_technology = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiOutCaps>.NativeClassPtr, "technology");
			MidiOutCaps.NativeFieldInfoPtr_voices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiOutCaps>.NativeClassPtr, "voices");
			MidiOutCaps.NativeFieldInfoPtr_notes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiOutCaps>.NativeClassPtr, "notes");
			MidiOutCaps.NativeFieldInfoPtr_channelMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiOutCaps>.NativeClassPtr, "channelMask");
			MidiOutCaps.NativeFieldInfoPtr_support = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiOutCaps>.NativeClassPtr, "support");
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x00007FC7 File Offset: 0x000061C7
		public MidiOutCaps(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x00007FD0 File Offset: 0x000061D0
		public MidiOutCaps()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MidiOutCaps>.NativeClassPtr))
		{
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x0600136A RID: 4970 RVA: 0x0005AF00 File Offset: 0x00059100
		// (set) Token: 0x0600136B RID: 4971 RVA: 0x00007FE2 File Offset: 0x000061E2
		public unsafe short mid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiOutCaps.NativeFieldInfoPtr_mid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiOutCaps.NativeFieldInfoPtr_mid)) = value;
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x0600136C RID: 4972 RVA: 0x0005AF28 File Offset: 0x00059128
		// (set) Token: 0x0600136D RID: 4973 RVA: 0x00007FFD File Offset: 0x000061FD
		public unsafe short pid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiOutCaps.NativeFieldInfoPtr_pid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiOutCaps.NativeFieldInfoPtr_pid)) = value;
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x0600136E RID: 4974 RVA: 0x0005AF50 File Offset: 0x00059150
		// (set) Token: 0x0600136F RID: 4975 RVA: 0x00008018 File Offset: 0x00006218
		public unsafe int driverVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiOutCaps.NativeFieldInfoPtr_driverVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiOutCaps.NativeFieldInfoPtr_driverVersion)) = value;
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06001370 RID: 4976 RVA: 0x0005AF78 File Offset: 0x00059178
		// (set) Token: 0x06001371 RID: 4977 RVA: 0x00008033 File Offset: 0x00006233
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiOutCaps.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiOutCaps.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06001372 RID: 4978 RVA: 0x0005AFA0 File Offset: 0x000591A0
		// (set) Token: 0x06001373 RID: 4979 RVA: 0x00008052 File Offset: 0x00006252
		public unsafe short technology
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiOutCaps.NativeFieldInfoPtr_technology);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiOutCaps.NativeFieldInfoPtr_technology)) = value;
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06001374 RID: 4980 RVA: 0x0005AFC8 File Offset: 0x000591C8
		// (set) Token: 0x06001375 RID: 4981 RVA: 0x0000806D File Offset: 0x0000626D
		public unsafe short voices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiOutCaps.NativeFieldInfoPtr_voices);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiOutCaps.NativeFieldInfoPtr_voices)) = value;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06001376 RID: 4982 RVA: 0x0005AFF0 File Offset: 0x000591F0
		// (set) Token: 0x06001377 RID: 4983 RVA: 0x00008088 File Offset: 0x00006288
		public unsafe short notes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiOutCaps.NativeFieldInfoPtr_notes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiOutCaps.NativeFieldInfoPtr_notes)) = value;
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06001378 RID: 4984 RVA: 0x0005B018 File Offset: 0x00059218
		// (set) Token: 0x06001379 RID: 4985 RVA: 0x000080A3 File Offset: 0x000062A3
		public unsafe short channelMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiOutCaps.NativeFieldInfoPtr_channelMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiOutCaps.NativeFieldInfoPtr_channelMask)) = value;
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x0600137A RID: 4986 RVA: 0x0005B040 File Offset: 0x00059240
		// (set) Token: 0x0600137B RID: 4987 RVA: 0x000080BE File Offset: 0x000062BE
		public unsafe int support
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiOutCaps.NativeFieldInfoPtr_support);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiOutCaps.NativeFieldInfoPtr_support)) = value;
			}
		}

		// Token: 0x04001508 RID: 5384
		private static readonly IntPtr NativeFieldInfoPtr_mid;

		// Token: 0x04001509 RID: 5385
		private static readonly IntPtr NativeFieldInfoPtr_pid;

		// Token: 0x0400150A RID: 5386
		private static readonly IntPtr NativeFieldInfoPtr_driverVersion;

		// Token: 0x0400150B RID: 5387
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x0400150C RID: 5388
		private static readonly IntPtr NativeFieldInfoPtr_technology;

		// Token: 0x0400150D RID: 5389
		private static readonly IntPtr NativeFieldInfoPtr_voices;

		// Token: 0x0400150E RID: 5390
		private static readonly IntPtr NativeFieldInfoPtr_notes;

		// Token: 0x0400150F RID: 5391
		private static readonly IntPtr NativeFieldInfoPtr_channelMask;

		// Token: 0x04001510 RID: 5392
		private static readonly IntPtr NativeFieldInfoPtr_support;
	}
}
