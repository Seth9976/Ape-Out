using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x02000010 RID: 16
	[Serializable]
	public class SequencerBagEntry : Object
	{
		// Token: 0x0600028F RID: 655 RVA: 0x0003AA44 File Offset: 0x00038C44
		// Note: this type is marked as 'beforefieldinit'.
		static SequencerBagEntry()
		{
			Il2CppClassPointerStore<SequencerBagEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SequencerBagEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequencerBagEntry>.NativeClassPtr);
			SequencerBagEntry.NativeFieldInfoPtr_clip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerBagEntry>.NativeClassPtr, "clip");
			SequencerBagEntry.NativeFieldInfoPtr_beatCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerBagEntry>.NativeClassPtr, "beatCount");
			SequencerBagEntry.NativeFieldInfoPtr_startingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerBagEntry>.NativeClassPtr, "startingIndex");
			SequencerBagEntry.NativeFieldInfoPtr_noteCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerBagEntry>.NativeClassPtr, "noteCount");
			SequencerBagEntry.NativeFieldInfoPtr_intensityPercentile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerBagEntry>.NativeClassPtr, "intensityPercentile");
			SequencerBagEntry.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerBagEntry>.NativeClassPtr, 100663417);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0003AAEC File Offset: 0x00038CEC
		[CallerCount(0)]
		public unsafe SequencerBagEntry(int _clip, int _beatCount, int _startingIndex, int _noteCount, float _intensityPercentile)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequencerBagEntry>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref _clip;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _beatCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _startingIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _noteCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _intensityPercentile;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequencerBagEntry.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00003F77 File Offset: 0x00002177
		public SequencerBagEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0003AB6C File Offset: 0x00038D6C
		// (set) Token: 0x06000293 RID: 659 RVA: 0x00003F80 File Offset: 0x00002180
		public unsafe int clip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequencerBagEntry.NativeFieldInfoPtr_clip);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequencerBagEntry.NativeFieldInfoPtr_clip)) = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000294 RID: 660 RVA: 0x0003AB94 File Offset: 0x00038D94
		// (set) Token: 0x06000295 RID: 661 RVA: 0x00003F9B File Offset: 0x0000219B
		public unsafe int beatCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequencerBagEntry.NativeFieldInfoPtr_beatCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequencerBagEntry.NativeFieldInfoPtr_beatCount)) = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0003ABBC File Offset: 0x00038DBC
		// (set) Token: 0x06000297 RID: 663 RVA: 0x00003FB6 File Offset: 0x000021B6
		public unsafe int startingIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequencerBagEntry.NativeFieldInfoPtr_startingIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequencerBagEntry.NativeFieldInfoPtr_startingIndex)) = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000298 RID: 664 RVA: 0x0003ABE4 File Offset: 0x00038DE4
		// (set) Token: 0x06000299 RID: 665 RVA: 0x00003FD1 File Offset: 0x000021D1
		public unsafe int noteCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequencerBagEntry.NativeFieldInfoPtr_noteCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequencerBagEntry.NativeFieldInfoPtr_noteCount)) = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600029A RID: 666 RVA: 0x0003AC0C File Offset: 0x00038E0C
		// (set) Token: 0x0600029B RID: 667 RVA: 0x00003FEC File Offset: 0x000021EC
		public unsafe float intensityPercentile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequencerBagEntry.NativeFieldInfoPtr_intensityPercentile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequencerBagEntry.NativeFieldInfoPtr_intensityPercentile)) = value;
			}
		}

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeFieldInfoPtr_clip;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeFieldInfoPtr_beatCount;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeFieldInfoPtr_startingIndex;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeFieldInfoPtr_noteCount;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeFieldInfoPtr_intensityPercentile;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Single_0;
	}
}
