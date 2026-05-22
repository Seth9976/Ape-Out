using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x02000198 RID: 408
	public class MidiDeviceException : DeviceException
	{
		// Token: 0x0600132A RID: 4906 RVA: 0x0005A58C File Offset: 0x0005878C
		// Note: this type is marked as 'beforefieldinit'.
		static MidiDeviceException()
		{
			Il2CppClassPointerStore<MidiDeviceException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "MidiDeviceException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MidiDeviceException>.NativeClassPtr);
			MidiDeviceException.NativeFieldInfoPtr_MIDIERR_UNPREPARED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiDeviceException>.NativeClassPtr, "MIDIERR_UNPREPARED");
			MidiDeviceException.NativeFieldInfoPtr_MIDIERR_STILLPLAYING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiDeviceException>.NativeClassPtr, "MIDIERR_STILLPLAYING");
			MidiDeviceException.NativeFieldInfoPtr_MIDIERR_NOMAP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiDeviceException>.NativeClassPtr, "MIDIERR_NOMAP");
			MidiDeviceException.NativeFieldInfoPtr_MIDIERR_NOTREADY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiDeviceException>.NativeClassPtr, "MIDIERR_NOTREADY");
			MidiDeviceException.NativeFieldInfoPtr_MIDIERR_NODEVICE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiDeviceException>.NativeClassPtr, "MIDIERR_NODEVICE");
			MidiDeviceException.NativeFieldInfoPtr_MIDIERR_INVALIDSETUP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiDeviceException>.NativeClassPtr, "MIDIERR_INVALIDSETUP");
			MidiDeviceException.NativeFieldInfoPtr_MIDIERR_BADOPENMODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiDeviceException>.NativeClassPtr, "MIDIERR_BADOPENMODE");
			MidiDeviceException.NativeFieldInfoPtr_MIDIERR_DONT_CONTINUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiDeviceException>.NativeClassPtr, "MIDIERR_DONT_CONTINUE");
			MidiDeviceException.NativeFieldInfoPtr_MIDIERR_LASTERROR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiDeviceException>.NativeClassPtr, "MIDIERR_LASTERROR");
			MidiDeviceException.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiDeviceException>.NativeClassPtr, 100666065);
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x0005A684 File Offset: 0x00058884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MidiDeviceException(int errCode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MidiDeviceException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref errCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiDeviceException.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x00007DB5 File Offset: 0x00005FB5
		public MidiDeviceException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x0600132D RID: 4909 RVA: 0x0005A6CC File Offset: 0x000588CC
		// (set) Token: 0x0600132E RID: 4910 RVA: 0x00007DBE File Offset: 0x00005FBE
		public unsafe static int MIDIERR_UNPREPARED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MidiDeviceException.NativeFieldInfoPtr_MIDIERR_UNPREPARED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MidiDeviceException.NativeFieldInfoPtr_MIDIERR_UNPREPARED, (void*)(&value));
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x0600132F RID: 4911 RVA: 0x0005A6E8 File Offset: 0x000588E8
		// (set) Token: 0x06001330 RID: 4912 RVA: 0x00007DCC File Offset: 0x00005FCC
		public unsafe static int MIDIERR_STILLPLAYING
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MidiDeviceException.NativeFieldInfoPtr_MIDIERR_STILLPLAYING, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MidiDeviceException.NativeFieldInfoPtr_MIDIERR_STILLPLAYING, (void*)(&value));
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06001331 RID: 4913 RVA: 0x0005A704 File Offset: 0x00058904
		// (set) Token: 0x06001332 RID: 4914 RVA: 0x00007DDA File Offset: 0x00005FDA
		public unsafe static int MIDIERR_NOMAP
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MidiDeviceException.NativeFieldInfoPtr_MIDIERR_NOMAP, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MidiDeviceException.NativeFieldInfoPtr_MIDIERR_NOMAP, (void*)(&value));
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06001333 RID: 4915 RVA: 0x0005A720 File Offset: 0x00058920
		// (set) Token: 0x06001334 RID: 4916 RVA: 0x00007DE8 File Offset: 0x00005FE8
		public unsafe static int MIDIERR_NOTREADY
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MidiDeviceException.NativeFieldInfoPtr_MIDIERR_NOTREADY, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MidiDeviceException.NativeFieldInfoPtr_MIDIERR_NOTREADY, (void*)(&value));
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06001335 RID: 4917 RVA: 0x0005A73C File Offset: 0x0005893C
		// (set) Token: 0x06001336 RID: 4918 RVA: 0x00007DF6 File Offset: 0x00005FF6
		public unsafe static int MIDIERR_NODEVICE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MidiDeviceException.NativeFieldInfoPtr_MIDIERR_NODEVICE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MidiDeviceException.NativeFieldInfoPtr_MIDIERR_NODEVICE, (void*)(&value));
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06001337 RID: 4919 RVA: 0x0005A758 File Offset: 0x00058958
		// (set) Token: 0x06001338 RID: 4920 RVA: 0x00007E04 File Offset: 0x00006004
		public unsafe static int MIDIERR_INVALIDSETUP
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MidiDeviceException.NativeFieldInfoPtr_MIDIERR_INVALIDSETUP, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MidiDeviceException.NativeFieldInfoPtr_MIDIERR_INVALIDSETUP, (void*)(&value));
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06001339 RID: 4921 RVA: 0x0005A774 File Offset: 0x00058974
		// (set) Token: 0x0600133A RID: 4922 RVA: 0x00007E12 File Offset: 0x00006012
		public unsafe static int MIDIERR_BADOPENMODE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MidiDeviceException.NativeFieldInfoPtr_MIDIERR_BADOPENMODE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MidiDeviceException.NativeFieldInfoPtr_MIDIERR_BADOPENMODE, (void*)(&value));
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x0600133B RID: 4923 RVA: 0x0005A790 File Offset: 0x00058990
		// (set) Token: 0x0600133C RID: 4924 RVA: 0x00007E20 File Offset: 0x00006020
		public unsafe static int MIDIERR_DONT_CONTINUE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MidiDeviceException.NativeFieldInfoPtr_MIDIERR_DONT_CONTINUE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MidiDeviceException.NativeFieldInfoPtr_MIDIERR_DONT_CONTINUE, (void*)(&value));
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x0600133D RID: 4925 RVA: 0x0005A7AC File Offset: 0x000589AC
		// (set) Token: 0x0600133E RID: 4926 RVA: 0x00007E2E File Offset: 0x0000602E
		public unsafe static int MIDIERR_LASTERROR
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MidiDeviceException.NativeFieldInfoPtr_MIDIERR_LASTERROR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MidiDeviceException.NativeFieldInfoPtr_MIDIERR_LASTERROR, (void*)(&value));
			}
		}

		// Token: 0x040014E8 RID: 5352
		private static readonly IntPtr NativeFieldInfoPtr_MIDIERR_UNPREPARED;

		// Token: 0x040014E9 RID: 5353
		private static readonly IntPtr NativeFieldInfoPtr_MIDIERR_STILLPLAYING;

		// Token: 0x040014EA RID: 5354
		private static readonly IntPtr NativeFieldInfoPtr_MIDIERR_NOMAP;

		// Token: 0x040014EB RID: 5355
		private static readonly IntPtr NativeFieldInfoPtr_MIDIERR_NOTREADY;

		// Token: 0x040014EC RID: 5356
		private static readonly IntPtr NativeFieldInfoPtr_MIDIERR_NODEVICE;

		// Token: 0x040014ED RID: 5357
		private static readonly IntPtr NativeFieldInfoPtr_MIDIERR_INVALIDSETUP;

		// Token: 0x040014EE RID: 5358
		private static readonly IntPtr NativeFieldInfoPtr_MIDIERR_BADOPENMODE;

		// Token: 0x040014EF RID: 5359
		private static readonly IntPtr NativeFieldInfoPtr_MIDIERR_DONT_CONTINUE;

		// Token: 0x040014F0 RID: 5360
		private static readonly IntPtr NativeFieldInfoPtr_MIDIERR_LASTERROR;

		// Token: 0x040014F1 RID: 5361
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
	}
}
