using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000068 RID: 104
	public sealed class Internal_DrawTextureArguments : ValueType
	{
		// Token: 0x0600070B RID: 1803 RVA: 0x00027340 File Offset: 0x00025540
		// Note: this type is marked as 'beforefieldinit'.
		static Internal_DrawTextureArguments()
		{
			Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Internal_DrawTextureArguments");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr);
			Internal_DrawTextureArguments.NativeFieldInfoPtr_screenRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr, "screenRect");
			Internal_DrawTextureArguments.NativeFieldInfoPtr_sourceRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr, "sourceRect");
			Internal_DrawTextureArguments.NativeFieldInfoPtr_leftBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr, "leftBorder");
			Internal_DrawTextureArguments.NativeFieldInfoPtr_rightBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr, "rightBorder");
			Internal_DrawTextureArguments.NativeFieldInfoPtr_topBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr, "topBorder");
			Internal_DrawTextureArguments.NativeFieldInfoPtr_bottomBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr, "bottomBorder");
			Internal_DrawTextureArguments.NativeFieldInfoPtr_leftBorderColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr, "leftBorderColor");
			Internal_DrawTextureArguments.NativeFieldInfoPtr_rightBorderColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr, "rightBorderColor");
			Internal_DrawTextureArguments.NativeFieldInfoPtr_topBorderColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr, "topBorderColor");
			Internal_DrawTextureArguments.NativeFieldInfoPtr_bottomBorderColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr, "bottomBorderColor");
			Internal_DrawTextureArguments.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr, "color");
			Internal_DrawTextureArguments.NativeFieldInfoPtr_borderWidths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr, "borderWidths");
			Internal_DrawTextureArguments.NativeFieldInfoPtr_cornerRadiuses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr, "cornerRadiuses");
			Internal_DrawTextureArguments.NativeFieldInfoPtr_smoothCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr, "smoothCorners");
			Internal_DrawTextureArguments.NativeFieldInfoPtr_pass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr, "pass");
			Internal_DrawTextureArguments.NativeFieldInfoPtr_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr, "texture");
			Internal_DrawTextureArguments.NativeFieldInfoPtr_mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr, "mat");
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x0000583A File Offset: 0x00003A3A
		public Internal_DrawTextureArguments(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00005843 File Offset: 0x00003A43
		public Internal_DrawTextureArguments()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr))
		{
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x000274C4 File Offset: 0x000256C4
		// (set) Token: 0x0600070F RID: 1807 RVA: 0x00005855 File Offset: 0x00003A55
		public unsafe Rect screenRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_screenRect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_screenRect)) = value;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x000274EC File Offset: 0x000256EC
		// (set) Token: 0x06000711 RID: 1809 RVA: 0x00005870 File Offset: 0x00003A70
		public unsafe Rect sourceRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_sourceRect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_sourceRect)) = value;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x00027514 File Offset: 0x00025714
		// (set) Token: 0x06000713 RID: 1811 RVA: 0x0000588B File Offset: 0x00003A8B
		public unsafe int leftBorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_leftBorder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_leftBorder)) = value;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x0002753C File Offset: 0x0002573C
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x000058A6 File Offset: 0x00003AA6
		public unsafe int rightBorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_rightBorder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_rightBorder)) = value;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x00027564 File Offset: 0x00025764
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x000058C1 File Offset: 0x00003AC1
		public unsafe int topBorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_topBorder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_topBorder)) = value;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x0002758C File Offset: 0x0002578C
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x000058DC File Offset: 0x00003ADC
		public unsafe int bottomBorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_bottomBorder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_bottomBorder)) = value;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x000275B4 File Offset: 0x000257B4
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x000058F7 File Offset: 0x00003AF7
		public unsafe Color leftBorderColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_leftBorderColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_leftBorderColor)) = value;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x000275DC File Offset: 0x000257DC
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x00005912 File Offset: 0x00003B12
		public unsafe Color rightBorderColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_rightBorderColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_rightBorderColor)) = value;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x00027604 File Offset: 0x00025804
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x0000592D File Offset: 0x00003B2D
		public unsafe Color topBorderColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_topBorderColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_topBorderColor)) = value;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x0002762C File Offset: 0x0002582C
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x00005948 File Offset: 0x00003B48
		public unsafe Color bottomBorderColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_bottomBorderColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_bottomBorderColor)) = value;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x00027654 File Offset: 0x00025854
		// (set) Token: 0x06000723 RID: 1827 RVA: 0x00005963 File Offset: 0x00003B63
		public unsafe Color color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_color)) = value;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x0002767C File Offset: 0x0002587C
		// (set) Token: 0x06000725 RID: 1829 RVA: 0x0000597E File Offset: 0x00003B7E
		public unsafe Vector4 borderWidths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_borderWidths);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_borderWidths)) = value;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x000276A4 File Offset: 0x000258A4
		// (set) Token: 0x06000727 RID: 1831 RVA: 0x00005999 File Offset: 0x00003B99
		public unsafe Vector4 cornerRadiuses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_cornerRadiuses);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_cornerRadiuses)) = value;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x000276CC File Offset: 0x000258CC
		// (set) Token: 0x06000729 RID: 1833 RVA: 0x000059B4 File Offset: 0x00003BB4
		public unsafe bool smoothCorners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_smoothCorners);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_smoothCorners)) = value;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x000276F4 File Offset: 0x000258F4
		// (set) Token: 0x0600072B RID: 1835 RVA: 0x000059CF File Offset: 0x00003BCF
		public unsafe int pass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_pass);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_pass)) = value;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x0002771C File Offset: 0x0002591C
		// (set) Token: 0x0600072D RID: 1837 RVA: 0x000059EA File Offset: 0x00003BEA
		public unsafe Texture texture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_texture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_texture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x0002774C File Offset: 0x0002594C
		// (set) Token: 0x0600072F RID: 1839 RVA: 0x00005A09 File Offset: 0x00003C09
		public unsafe Material mat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_mat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_mat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeFieldInfoPtr_screenRect;

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeFieldInfoPtr_sourceRect;

		// Token: 0x040004E5 RID: 1253
		private static readonly IntPtr NativeFieldInfoPtr_leftBorder;

		// Token: 0x040004E6 RID: 1254
		private static readonly IntPtr NativeFieldInfoPtr_rightBorder;

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeFieldInfoPtr_topBorder;

		// Token: 0x040004E8 RID: 1256
		private static readonly IntPtr NativeFieldInfoPtr_bottomBorder;

		// Token: 0x040004E9 RID: 1257
		private static readonly IntPtr NativeFieldInfoPtr_leftBorderColor;

		// Token: 0x040004EA RID: 1258
		private static readonly IntPtr NativeFieldInfoPtr_rightBorderColor;

		// Token: 0x040004EB RID: 1259
		private static readonly IntPtr NativeFieldInfoPtr_topBorderColor;

		// Token: 0x040004EC RID: 1260
		private static readonly IntPtr NativeFieldInfoPtr_bottomBorderColor;

		// Token: 0x040004ED RID: 1261
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeFieldInfoPtr_borderWidths;

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeFieldInfoPtr_cornerRadiuses;

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeFieldInfoPtr_smoothCorners;

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeFieldInfoPtr_pass;

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeFieldInfoPtr_texture;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeFieldInfoPtr_mat;
	}
}
