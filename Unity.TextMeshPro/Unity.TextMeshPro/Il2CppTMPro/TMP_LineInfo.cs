using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppTMPro
{
	// Token: 0x0200002E RID: 46
	[StructLayout(2)]
	public struct TMP_LineInfo
	{
		// Token: 0x0600052A RID: 1322 RVA: 0x0001C0D0 File Offset: 0x0001A2D0
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_LineInfo()
		{
			Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_LineInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr);
			TMP_LineInfo.NativeFieldInfoPtr_controlCharacterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "controlCharacterCount");
			TMP_LineInfo.NativeFieldInfoPtr_characterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "characterCount");
			TMP_LineInfo.NativeFieldInfoPtr_visibleCharacterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "visibleCharacterCount");
			TMP_LineInfo.NativeFieldInfoPtr_spaceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "spaceCount");
			TMP_LineInfo.NativeFieldInfoPtr_wordCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "wordCount");
			TMP_LineInfo.NativeFieldInfoPtr_firstCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "firstCharacterIndex");
			TMP_LineInfo.NativeFieldInfoPtr_firstVisibleCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "firstVisibleCharacterIndex");
			TMP_LineInfo.NativeFieldInfoPtr_lastCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "lastCharacterIndex");
			TMP_LineInfo.NativeFieldInfoPtr_lastVisibleCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "lastVisibleCharacterIndex");
			TMP_LineInfo.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "length");
			TMP_LineInfo.NativeFieldInfoPtr_lineHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "lineHeight");
			TMP_LineInfo.NativeFieldInfoPtr_ascender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "ascender");
			TMP_LineInfo.NativeFieldInfoPtr_baseline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "baseline");
			TMP_LineInfo.NativeFieldInfoPtr_descender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "descender");
			TMP_LineInfo.NativeFieldInfoPtr_maxAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "maxAdvance");
			TMP_LineInfo.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "width");
			TMP_LineInfo.NativeFieldInfoPtr_marginLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "marginLeft");
			TMP_LineInfo.NativeFieldInfoPtr_marginRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "marginRight");
			TMP_LineInfo.NativeFieldInfoPtr_alignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "alignment");
			TMP_LineInfo.NativeFieldInfoPtr_lineExtents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "lineExtents");
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00004601 File Offset: 0x00002801
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeFieldInfoPtr_controlCharacterCount;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeFieldInfoPtr_characterCount;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeFieldInfoPtr_visibleCharacterCount;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeFieldInfoPtr_spaceCount;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeFieldInfoPtr_wordCount;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeFieldInfoPtr_firstCharacterIndex;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeFieldInfoPtr_firstVisibleCharacterIndex;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeFieldInfoPtr_lastCharacterIndex;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeFieldInfoPtr_lastVisibleCharacterIndex;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeFieldInfoPtr_lineHeight;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeFieldInfoPtr_ascender;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeFieldInfoPtr_baseline;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeFieldInfoPtr_descender;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeFieldInfoPtr_maxAdvance;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeFieldInfoPtr_width;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeFieldInfoPtr_marginLeft;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeFieldInfoPtr_marginRight;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeFieldInfoPtr_alignment;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeFieldInfoPtr_lineExtents;

		// Token: 0x040003DD RID: 989
		[FieldOffset(0)]
		public int controlCharacterCount;

		// Token: 0x040003DE RID: 990
		[FieldOffset(4)]
		public int characterCount;

		// Token: 0x040003DF RID: 991
		[FieldOffset(8)]
		public int visibleCharacterCount;

		// Token: 0x040003E0 RID: 992
		[FieldOffset(12)]
		public int spaceCount;

		// Token: 0x040003E1 RID: 993
		[FieldOffset(16)]
		public int wordCount;

		// Token: 0x040003E2 RID: 994
		[FieldOffset(20)]
		public int firstCharacterIndex;

		// Token: 0x040003E3 RID: 995
		[FieldOffset(24)]
		public int firstVisibleCharacterIndex;

		// Token: 0x040003E4 RID: 996
		[FieldOffset(28)]
		public int lastCharacterIndex;

		// Token: 0x040003E5 RID: 997
		[FieldOffset(32)]
		public int lastVisibleCharacterIndex;

		// Token: 0x040003E6 RID: 998
		[FieldOffset(36)]
		public float length;

		// Token: 0x040003E7 RID: 999
		[FieldOffset(40)]
		public float lineHeight;

		// Token: 0x040003E8 RID: 1000
		[FieldOffset(44)]
		public float ascender;

		// Token: 0x040003E9 RID: 1001
		[FieldOffset(48)]
		public float baseline;

		// Token: 0x040003EA RID: 1002
		[FieldOffset(52)]
		public float descender;

		// Token: 0x040003EB RID: 1003
		[FieldOffset(56)]
		public float maxAdvance;

		// Token: 0x040003EC RID: 1004
		[FieldOffset(60)]
		public float width;

		// Token: 0x040003ED RID: 1005
		[FieldOffset(64)]
		public float marginLeft;

		// Token: 0x040003EE RID: 1006
		[FieldOffset(68)]
		public float marginRight;

		// Token: 0x040003EF RID: 1007
		[FieldOffset(72)]
		public HorizontalAlignmentOptions alignment;

		// Token: 0x040003F0 RID: 1008
		[FieldOffset(76)]
		public Extents lineExtents;
	}
}
