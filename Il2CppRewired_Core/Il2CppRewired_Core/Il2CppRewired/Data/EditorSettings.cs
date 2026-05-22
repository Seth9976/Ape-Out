using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppRewired.Data
{
	// Token: 0x020000A0 RID: 160
	public class EditorSettings : ScriptableObject
	{
		// Token: 0x0600140E RID: 5134 RVA: 0x00078280 File Offset: 0x00076480
		// Note: this type is marked as 'beforefieldinit'.
		static EditorSettings()
		{
			Il2CppClassPointerStore<EditorSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data", "EditorSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr);
			EditorSettings.NativeFieldInfoPtr_programVersion1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, "programVersion1");
			EditorSettings.NativeFieldInfoPtr_programVersion2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, "programVersion2");
			EditorSettings.NativeFieldInfoPtr_programVersion3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, "programVersion3");
			EditorSettings.NativeFieldInfoPtr_programVersion4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, "programVersion4");
			EditorSettings.NativeFieldInfoPtr_dataVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, "dataVersion");
			EditorSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, 100666668);
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x00078328 File Offset: 0x00076528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EditorSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x00008BDD File Offset: 0x00006DDD
		public EditorSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06001411 RID: 5137 RVA: 0x00078364 File Offset: 0x00076564
		// (set) Token: 0x06001412 RID: 5138 RVA: 0x00008BE6 File Offset: 0x00006DE6
		public unsafe int programVersion1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_programVersion1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_programVersion1)) = value;
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06001413 RID: 5139 RVA: 0x0007838C File Offset: 0x0007658C
		// (set) Token: 0x06001414 RID: 5140 RVA: 0x00008C01 File Offset: 0x00006E01
		public unsafe int programVersion2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_programVersion2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_programVersion2)) = value;
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06001415 RID: 5141 RVA: 0x000783B4 File Offset: 0x000765B4
		// (set) Token: 0x06001416 RID: 5142 RVA: 0x00008C1C File Offset: 0x00006E1C
		public unsafe int programVersion3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_programVersion3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_programVersion3)) = value;
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06001417 RID: 5143 RVA: 0x000783DC File Offset: 0x000765DC
		// (set) Token: 0x06001418 RID: 5144 RVA: 0x00008C37 File Offset: 0x00006E37
		public unsafe int programVersion4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_programVersion4);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_programVersion4)) = value;
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06001419 RID: 5145 RVA: 0x00078404 File Offset: 0x00076604
		// (set) Token: 0x0600141A RID: 5146 RVA: 0x00008C52 File Offset: 0x00006E52
		public unsafe int dataVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_dataVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_dataVersion)) = value;
			}
		}

		// Token: 0x04001034 RID: 4148
		private static readonly IntPtr NativeFieldInfoPtr_programVersion1;

		// Token: 0x04001035 RID: 4149
		private static readonly IntPtr NativeFieldInfoPtr_programVersion2;

		// Token: 0x04001036 RID: 4150
		private static readonly IntPtr NativeFieldInfoPtr_programVersion3;

		// Token: 0x04001037 RID: 4151
		private static readonly IntPtr NativeFieldInfoPtr_programVersion4;

		// Token: 0x04001038 RID: 4152
		private static readonly IntPtr NativeFieldInfoPtr_dataVersion;

		// Token: 0x04001039 RID: 4153
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
