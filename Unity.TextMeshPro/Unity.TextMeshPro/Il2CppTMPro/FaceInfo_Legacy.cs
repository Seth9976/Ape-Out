using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppTMPro
{
	// Token: 0x0200001B RID: 27
	[Serializable]
	public class FaceInfo_Legacy : Object
	{
		// Token: 0x060002AB RID: 683 RVA: 0x00013154 File Offset: 0x00011354
		// Note: this type is marked as 'beforefieldinit'.
		static FaceInfo_Legacy()
		{
			Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "FaceInfo_Legacy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr);
			FaceInfo_Legacy.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "Name");
			FaceInfo_Legacy.NativeFieldInfoPtr_PointSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "PointSize");
			FaceInfo_Legacy.NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "Scale");
			FaceInfo_Legacy.NativeFieldInfoPtr_CharacterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "CharacterCount");
			FaceInfo_Legacy.NativeFieldInfoPtr_LineHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "LineHeight");
			FaceInfo_Legacy.NativeFieldInfoPtr_Baseline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "Baseline");
			FaceInfo_Legacy.NativeFieldInfoPtr_Ascender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "Ascender");
			FaceInfo_Legacy.NativeFieldInfoPtr_CapHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "CapHeight");
			FaceInfo_Legacy.NativeFieldInfoPtr_Descender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "Descender");
			FaceInfo_Legacy.NativeFieldInfoPtr_CenterLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "CenterLine");
			FaceInfo_Legacy.NativeFieldInfoPtr_SuperscriptOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "SuperscriptOffset");
			FaceInfo_Legacy.NativeFieldInfoPtr_SubscriptOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "SubscriptOffset");
			FaceInfo_Legacy.NativeFieldInfoPtr_SubSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "SubSize");
			FaceInfo_Legacy.NativeFieldInfoPtr_Underline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "Underline");
			FaceInfo_Legacy.NativeFieldInfoPtr_UnderlineThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "UnderlineThickness");
			FaceInfo_Legacy.NativeFieldInfoPtr_strikethrough = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "strikethrough");
			FaceInfo_Legacy.NativeFieldInfoPtr_strikethroughThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "strikethroughThickness");
			FaceInfo_Legacy.NativeFieldInfoPtr_TabWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "TabWidth");
			FaceInfo_Legacy.NativeFieldInfoPtr_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "Padding");
			FaceInfo_Legacy.NativeFieldInfoPtr_AtlasWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "AtlasWidth");
			FaceInfo_Legacy.NativeFieldInfoPtr_AtlasHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "AtlasHeight");
			FaceInfo_Legacy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, 100663621);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0001333C File Offset: 0x0001153C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FaceInfo_Legacy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo_Legacy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x000034B8 File Offset: 0x000016B8
		public FaceInfo_Legacy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060002AE RID: 686 RVA: 0x00013378 File Offset: 0x00011578
		// (set) Token: 0x060002AF RID: 687 RVA: 0x000034C1 File Offset: 0x000016C1
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x000133A0 File Offset: 0x000115A0
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x000034E0 File Offset: 0x000016E0
		public unsafe float PointSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_PointSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_PointSize)) = value;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x000133C8 File Offset: 0x000115C8
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x000034FB File Offset: 0x000016FB
		public unsafe float Scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_Scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_Scale)) = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x000133F0 File Offset: 0x000115F0
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x00003516 File Offset: 0x00001716
		public unsafe int CharacterCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_CharacterCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_CharacterCount)) = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x00013418 File Offset: 0x00011618
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x00003531 File Offset: 0x00001731
		public unsafe float LineHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_LineHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_LineHeight)) = value;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x00013440 File Offset: 0x00011640
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x0000354C File Offset: 0x0000174C
		public unsafe float Baseline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_Baseline);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_Baseline)) = value;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060002BA RID: 698 RVA: 0x00013468 File Offset: 0x00011668
		// (set) Token: 0x060002BB RID: 699 RVA: 0x00003567 File Offset: 0x00001767
		public unsafe float Ascender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_Ascender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_Ascender)) = value;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060002BC RID: 700 RVA: 0x00013490 File Offset: 0x00011690
		// (set) Token: 0x060002BD RID: 701 RVA: 0x00003582 File Offset: 0x00001782
		public unsafe float CapHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_CapHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_CapHeight)) = value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060002BE RID: 702 RVA: 0x000134B8 File Offset: 0x000116B8
		// (set) Token: 0x060002BF RID: 703 RVA: 0x0000359D File Offset: 0x0000179D
		public unsafe float Descender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_Descender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_Descender)) = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x000134E0 File Offset: 0x000116E0
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x000035B8 File Offset: 0x000017B8
		public unsafe float CenterLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_CenterLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_CenterLine)) = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x00013508 File Offset: 0x00011708
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x000035D3 File Offset: 0x000017D3
		public unsafe float SuperscriptOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_SuperscriptOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_SuperscriptOffset)) = value;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x00013530 File Offset: 0x00011730
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x000035EE File Offset: 0x000017EE
		public unsafe float SubscriptOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_SubscriptOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_SubscriptOffset)) = value;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x00013558 File Offset: 0x00011758
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x00003609 File Offset: 0x00001809
		public unsafe float SubSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_SubSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_SubSize)) = value;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x00013580 File Offset: 0x00011780
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x00003624 File Offset: 0x00001824
		public unsafe float Underline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_Underline);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_Underline)) = value;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060002CA RID: 714 RVA: 0x000135A8 File Offset: 0x000117A8
		// (set) Token: 0x060002CB RID: 715 RVA: 0x0000363F File Offset: 0x0000183F
		public unsafe float UnderlineThickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_UnderlineThickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_UnderlineThickness)) = value;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060002CC RID: 716 RVA: 0x000135D0 File Offset: 0x000117D0
		// (set) Token: 0x060002CD RID: 717 RVA: 0x0000365A File Offset: 0x0000185A
		public unsafe float strikethrough
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_strikethrough);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_strikethrough)) = value;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060002CE RID: 718 RVA: 0x000135F8 File Offset: 0x000117F8
		// (set) Token: 0x060002CF RID: 719 RVA: 0x00003675 File Offset: 0x00001875
		public unsafe float strikethroughThickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_strikethroughThickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_strikethroughThickness)) = value;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x00013620 File Offset: 0x00011820
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x00003690 File Offset: 0x00001890
		public unsafe float TabWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_TabWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_TabWidth)) = value;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x00013648 File Offset: 0x00011848
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x000036AB File Offset: 0x000018AB
		public unsafe float Padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_Padding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_Padding)) = value;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x00013670 File Offset: 0x00011870
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x000036C6 File Offset: 0x000018C6
		public unsafe float AtlasWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_AtlasWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_AtlasWidth)) = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x00013698 File Offset: 0x00011898
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x000036E1 File Offset: 0x000018E1
		public unsafe float AtlasHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_AtlasHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_AtlasHeight)) = value;
			}
		}

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeFieldInfoPtr_PointSize;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeFieldInfoPtr_Scale;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeFieldInfoPtr_CharacterCount;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeFieldInfoPtr_LineHeight;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeFieldInfoPtr_Baseline;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeFieldInfoPtr_Ascender;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeFieldInfoPtr_CapHeight;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeFieldInfoPtr_Descender;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeFieldInfoPtr_CenterLine;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeFieldInfoPtr_SuperscriptOffset;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeFieldInfoPtr_SubscriptOffset;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeFieldInfoPtr_SubSize;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeFieldInfoPtr_Underline;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeFieldInfoPtr_UnderlineThickness;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeFieldInfoPtr_strikethrough;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeFieldInfoPtr_strikethroughThickness;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeFieldInfoPtr_TabWidth;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeFieldInfoPtr_Padding;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeFieldInfoPtr_AtlasWidth;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeFieldInfoPtr_AtlasHeight;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
