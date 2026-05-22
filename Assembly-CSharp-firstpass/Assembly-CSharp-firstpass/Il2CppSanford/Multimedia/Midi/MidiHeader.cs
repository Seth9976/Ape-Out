using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x02000199 RID: 409
	public sealed class MidiHeader : ValueType
	{
		// Token: 0x0600133F RID: 4927 RVA: 0x0005A7C8 File Offset: 0x000589C8
		// Note: this type is marked as 'beforefieldinit'.
		static MidiHeader()
		{
			Il2CppClassPointerStore<MidiHeader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "MidiHeader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MidiHeader>.NativeClassPtr);
			MidiHeader.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiHeader>.NativeClassPtr, "data");
			MidiHeader.NativeFieldInfoPtr_bufferLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiHeader>.NativeClassPtr, "bufferLength");
			MidiHeader.NativeFieldInfoPtr_bytesRecorded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiHeader>.NativeClassPtr, "bytesRecorded");
			MidiHeader.NativeFieldInfoPtr_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiHeader>.NativeClassPtr, "user");
			MidiHeader.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiHeader>.NativeClassPtr, "flags");
			MidiHeader.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiHeader>.NativeClassPtr, "next");
			MidiHeader.NativeFieldInfoPtr_reserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiHeader>.NativeClassPtr, "reserved");
			MidiHeader.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiHeader>.NativeClassPtr, "offset");
			MidiHeader.NativeFieldInfoPtr_reservedArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiHeader>.NativeClassPtr, "reservedArray");
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x00007E3C File Offset: 0x0000603C
		public MidiHeader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x00007E45 File Offset: 0x00006045
		public MidiHeader()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MidiHeader>.NativeClassPtr))
		{
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06001342 RID: 4930 RVA: 0x0005A8AC File Offset: 0x00058AAC
		// (set) Token: 0x06001343 RID: 4931 RVA: 0x00007E57 File Offset: 0x00006057
		public unsafe IntPtr data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiHeader.NativeFieldInfoPtr_data);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiHeader.NativeFieldInfoPtr_data)) = value;
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06001344 RID: 4932 RVA: 0x0005A8D4 File Offset: 0x00058AD4
		// (set) Token: 0x06001345 RID: 4933 RVA: 0x00007E72 File Offset: 0x00006072
		public unsafe int bufferLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiHeader.NativeFieldInfoPtr_bufferLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiHeader.NativeFieldInfoPtr_bufferLength)) = value;
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06001346 RID: 4934 RVA: 0x0005A8FC File Offset: 0x00058AFC
		// (set) Token: 0x06001347 RID: 4935 RVA: 0x00007E8D File Offset: 0x0000608D
		public unsafe int bytesRecorded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiHeader.NativeFieldInfoPtr_bytesRecorded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiHeader.NativeFieldInfoPtr_bytesRecorded)) = value;
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06001348 RID: 4936 RVA: 0x0005A924 File Offset: 0x00058B24
		// (set) Token: 0x06001349 RID: 4937 RVA: 0x00007EA8 File Offset: 0x000060A8
		public unsafe int user
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiHeader.NativeFieldInfoPtr_user);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiHeader.NativeFieldInfoPtr_user)) = value;
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x0600134A RID: 4938 RVA: 0x0005A94C File Offset: 0x00058B4C
		// (set) Token: 0x0600134B RID: 4939 RVA: 0x00007EC3 File Offset: 0x000060C3
		public unsafe int flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiHeader.NativeFieldInfoPtr_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiHeader.NativeFieldInfoPtr_flags)) = value;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x0600134C RID: 4940 RVA: 0x0005A974 File Offset: 0x00058B74
		// (set) Token: 0x0600134D RID: 4941 RVA: 0x00007EDE File Offset: 0x000060DE
		public unsafe IntPtr next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiHeader.NativeFieldInfoPtr_next);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiHeader.NativeFieldInfoPtr_next)) = value;
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x0600134E RID: 4942 RVA: 0x0005A99C File Offset: 0x00058B9C
		// (set) Token: 0x0600134F RID: 4943 RVA: 0x00007EF9 File Offset: 0x000060F9
		public unsafe int reserved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiHeader.NativeFieldInfoPtr_reserved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiHeader.NativeFieldInfoPtr_reserved)) = value;
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06001350 RID: 4944 RVA: 0x0005A9C4 File Offset: 0x00058BC4
		// (set) Token: 0x06001351 RID: 4945 RVA: 0x00007F14 File Offset: 0x00006114
		public unsafe int offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiHeader.NativeFieldInfoPtr_offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiHeader.NativeFieldInfoPtr_offset)) = value;
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06001352 RID: 4946 RVA: 0x0005A9EC File Offset: 0x00058BEC
		// (set) Token: 0x06001353 RID: 4947 RVA: 0x00007F2F File Offset: 0x0000612F
		public unsafe Il2CppStructArray<int> reservedArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiHeader.NativeFieldInfoPtr_reservedArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiHeader.NativeFieldInfoPtr_reservedArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014F2 RID: 5362
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040014F3 RID: 5363
		private static readonly IntPtr NativeFieldInfoPtr_bufferLength;

		// Token: 0x040014F4 RID: 5364
		private static readonly IntPtr NativeFieldInfoPtr_bytesRecorded;

		// Token: 0x040014F5 RID: 5365
		private static readonly IntPtr NativeFieldInfoPtr_user;

		// Token: 0x040014F6 RID: 5366
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x040014F7 RID: 5367
		private static readonly IntPtr NativeFieldInfoPtr_next;

		// Token: 0x040014F8 RID: 5368
		private static readonly IntPtr NativeFieldInfoPtr_reserved;

		// Token: 0x040014F9 RID: 5369
		private static readonly IntPtr NativeFieldInfoPtr_offset;

		// Token: 0x040014FA RID: 5370
		private static readonly IntPtr NativeFieldInfoPtr_reservedArray;
	}
}
