using System;
using Il2CppAudioHelm;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000121 RID: 289
	public class LevelTransitionManager : MonoBehaviour
	{
		// Token: 0x060022A9 RID: 8873 RVA: 0x000948DC File Offset: 0x00092ADC
		// Note: this type is marked as 'beforefieldinit'.
		static LevelTransitionManager()
		{
			Il2CppClassPointerStore<LevelTransitionManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LevelTransitionManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LevelTransitionManager>.NativeClassPtr);
			LevelTransitionManager.NativeFieldInfoPtr_lab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelTransitionManager>.NativeClassPtr, "lab");
			LevelTransitionManager.NativeFieldInfoPtr_office1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelTransitionManager>.NativeClassPtr, "office1");
			LevelTransitionManager.NativeFieldInfoPtr_office2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelTransitionManager>.NativeClassPtr, "office2");
			LevelTransitionManager.NativeFieldInfoPtr_bunker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelTransitionManager>.NativeClassPtr, "bunker");
			LevelTransitionManager.NativeFieldInfoPtr_boat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelTransitionManager>.NativeClassPtr, "boat");
			LevelTransitionManager.NativeFieldInfoPtr_coverQuad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelTransitionManager>.NativeClassPtr, "coverQuad");
			LevelTransitionManager.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelTransitionManager>.NativeClassPtr, "me");
			LevelTransitionManager.NativeFieldInfoPtr_palMats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelTransitionManager>.NativeClassPtr, "palMats");
			LevelTransitionManager.NativeFieldInfoPtr_palQuad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelTransitionManager>.NativeClassPtr, "palQuad");
			LevelTransitionManager.NativeFieldInfoPtr_startflag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelTransitionManager>.NativeClassPtr, "startflag");
			LevelTransitionManager.NativeFieldInfoPtr_labTitles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelTransitionManager>.NativeClassPtr, "labTitles");
			LevelTransitionManager.NativeFieldInfoPtr_officeTitles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelTransitionManager>.NativeClassPtr, "officeTitles");
			LevelTransitionManager.NativeFieldInfoPtr_bunkerTitles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelTransitionManager>.NativeClassPtr, "bunkerTitles");
			LevelTransitionManager.NativeFieldInfoPtr_boatTitles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelTransitionManager>.NativeClassPtr, "boatTitles");
			LevelTransitionManager.NativeFieldInfoPtr_titles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelTransitionManager>.NativeClassPtr, "titles");
			LevelTransitionManager.NativeFieldInfoPtr_arcadeTitles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelTransitionManager>.NativeClassPtr, "arcadeTitles");
			LevelTransitionManager.NativeFieldInfoPtr_allTitles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelTransitionManager>.NativeClassPtr, "allTitles");
			LevelTransitionManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelTransitionManager>.NativeClassPtr, 100665992);
			LevelTransitionManager.NativeMethodInfoPtr_UpdateShit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelTransitionManager>.NativeClassPtr, 100665993);
			LevelTransitionManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelTransitionManager>.NativeClassPtr, 100665994);
			LevelTransitionManager.NativeMethodInfoPtr_ShowTitle_Public_Void_Note_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelTransitionManager>.NativeClassPtr, 100665995);
			LevelTransitionManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelTransitionManager>.NativeClassPtr, 100665996);
		}

		// Token: 0x060022AA RID: 8874 RVA: 0x00094AC4 File Offset: 0x00092CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69454, XrefRangeEnd = 69467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelTransitionManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022AB RID: 8875 RVA: 0x00094AF8 File Offset: 0x00092CF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 69487, RefRangeEnd = 69489, XrefRangeStart = 69467, XrefRangeEnd = 69487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateShit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelTransitionManager.NativeMethodInfoPtr_UpdateShit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022AC RID: 8876 RVA: 0x00094B2C File Offset: 0x00092D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69489, XrefRangeEnd = 69506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelTransitionManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022AD RID: 8877 RVA: 0x00094B60 File Offset: 0x00092D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69506, XrefRangeEnd = 69510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowTitle(Note note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref note;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelTransitionManager.NativeMethodInfoPtr_ShowTitle_Public_Void_Note_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x00094BA0 File Offset: 0x00092DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LevelTransitionManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LevelTransitionManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelTransitionManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022AF RID: 8879 RVA: 0x00018513 File Offset: 0x00016713
		public LevelTransitionManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x060022B0 RID: 8880 RVA: 0x00094BDC File Offset: 0x00092DDC
		// (set) Token: 0x060022B1 RID: 8881 RVA: 0x0001851C File Offset: 0x0001671C
		public unsafe GameObject lab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTransitionManager.NativeFieldInfoPtr_lab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTransitionManager.NativeFieldInfoPtr_lab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x060022B2 RID: 8882 RVA: 0x00094C0C File Offset: 0x00092E0C
		// (set) Token: 0x060022B3 RID: 8883 RVA: 0x0001853B File Offset: 0x0001673B
		public unsafe GameObject office1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTransitionManager.NativeFieldInfoPtr_office1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTransitionManager.NativeFieldInfoPtr_office1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x060022B4 RID: 8884 RVA: 0x00094C3C File Offset: 0x00092E3C
		// (set) Token: 0x060022B5 RID: 8885 RVA: 0x0001855A File Offset: 0x0001675A
		public unsafe GameObject office2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTransitionManager.NativeFieldInfoPtr_office2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTransitionManager.NativeFieldInfoPtr_office2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x060022B6 RID: 8886 RVA: 0x00094C6C File Offset: 0x00092E6C
		// (set) Token: 0x060022B7 RID: 8887 RVA: 0x00018579 File Offset: 0x00016779
		public unsafe Il2CppReferenceArray<GameObject> bunker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTransitionManager.NativeFieldInfoPtr_bunker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTransitionManager.NativeFieldInfoPtr_bunker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x060022B8 RID: 8888 RVA: 0x00094C9C File Offset: 0x00092E9C
		// (set) Token: 0x060022B9 RID: 8889 RVA: 0x00018598 File Offset: 0x00016798
		public unsafe Il2CppReferenceArray<GameObject> boat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTransitionManager.NativeFieldInfoPtr_boat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTransitionManager.NativeFieldInfoPtr_boat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x060022BA RID: 8890 RVA: 0x00094CCC File Offset: 0x00092ECC
		// (set) Token: 0x060022BB RID: 8891 RVA: 0x000185B7 File Offset: 0x000167B7
		public unsafe GameObject coverQuad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTransitionManager.NativeFieldInfoPtr_coverQuad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTransitionManager.NativeFieldInfoPtr_coverQuad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x060022BC RID: 8892 RVA: 0x00094CFC File Offset: 0x00092EFC
		// (set) Token: 0x060022BD RID: 8893 RVA: 0x000185D6 File Offset: 0x000167D6
		public unsafe static LevelTransitionManager me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LevelTransitionManager.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LevelTransitionManager>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LevelTransitionManager.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x060022BE RID: 8894 RVA: 0x00094D24 File Offset: 0x00092F24
		// (set) Token: 0x060022BF RID: 8895 RVA: 0x000185E8 File Offset: 0x000167E8
		public unsafe Il2CppReferenceArray<Material> palMats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTransitionManager.NativeFieldInfoPtr_palMats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTransitionManager.NativeFieldInfoPtr_palMats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x060022C0 RID: 8896 RVA: 0x00094D54 File Offset: 0x00092F54
		// (set) Token: 0x060022C1 RID: 8897 RVA: 0x00018607 File Offset: 0x00016807
		public unsafe Renderer palQuad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTransitionManager.NativeFieldInfoPtr_palQuad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTransitionManager.NativeFieldInfoPtr_palQuad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x060022C2 RID: 8898 RVA: 0x00094D84 File Offset: 0x00092F84
		// (set) Token: 0x060022C3 RID: 8899 RVA: 0x00018626 File Offset: 0x00016826
		public unsafe bool startflag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTransitionManager.NativeFieldInfoPtr_startflag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTransitionManager.NativeFieldInfoPtr_startflag)) = value;
			}
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x060022C4 RID: 8900 RVA: 0x00094DAC File Offset: 0x00092FAC
		// (set) Token: 0x060022C5 RID: 8901 RVA: 0x00018641 File Offset: 0x00016841
		public unsafe Il2CppReferenceArray<LevelTitle> labTitles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTransitionManager.NativeFieldInfoPtr_labTitles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LevelTitle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTransitionManager.NativeFieldInfoPtr_labTitles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x060022C6 RID: 8902 RVA: 0x00094DDC File Offset: 0x00092FDC
		// (set) Token: 0x060022C7 RID: 8903 RVA: 0x00018660 File Offset: 0x00016860
		public unsafe Il2CppReferenceArray<LevelTitle> officeTitles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTransitionManager.NativeFieldInfoPtr_officeTitles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LevelTitle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTransitionManager.NativeFieldInfoPtr_officeTitles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x060022C8 RID: 8904 RVA: 0x00094E0C File Offset: 0x0009300C
		// (set) Token: 0x060022C9 RID: 8905 RVA: 0x0001867F File Offset: 0x0001687F
		public unsafe Il2CppReferenceArray<LevelTitle> bunkerTitles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTransitionManager.NativeFieldInfoPtr_bunkerTitles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LevelTitle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTransitionManager.NativeFieldInfoPtr_bunkerTitles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x060022CA RID: 8906 RVA: 0x00094E3C File Offset: 0x0009303C
		// (set) Token: 0x060022CB RID: 8907 RVA: 0x0001869E File Offset: 0x0001689E
		public unsafe Il2CppReferenceArray<LevelTitle> boatTitles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTransitionManager.NativeFieldInfoPtr_boatTitles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LevelTitle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTransitionManager.NativeFieldInfoPtr_boatTitles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x060022CC RID: 8908 RVA: 0x00094E6C File Offset: 0x0009306C
		// (set) Token: 0x060022CD RID: 8909 RVA: 0x000186BD File Offset: 0x000168BD
		public unsafe Il2CppReferenceArray<LevelTitle> titles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTransitionManager.NativeFieldInfoPtr_titles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LevelTitle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTransitionManager.NativeFieldInfoPtr_titles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x060022CE RID: 8910 RVA: 0x00094E9C File Offset: 0x0009309C
		// (set) Token: 0x060022CF RID: 8911 RVA: 0x000186DC File Offset: 0x000168DC
		public unsafe Il2CppReferenceArray<LevelTitle> arcadeTitles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTransitionManager.NativeFieldInfoPtr_arcadeTitles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LevelTitle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTransitionManager.NativeFieldInfoPtr_arcadeTitles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x060022D0 RID: 8912 RVA: 0x00094ECC File Offset: 0x000930CC
		// (set) Token: 0x060022D1 RID: 8913 RVA: 0x000186FB File Offset: 0x000168FB
		public unsafe Il2CppReferenceArray<LevelTitle> allTitles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTransitionManager.NativeFieldInfoPtr_allTitles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LevelTitle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelTransitionManager.NativeFieldInfoPtr_allTitles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001472 RID: 5234
		private static readonly IntPtr NativeFieldInfoPtr_lab;

		// Token: 0x04001473 RID: 5235
		private static readonly IntPtr NativeFieldInfoPtr_office1;

		// Token: 0x04001474 RID: 5236
		private static readonly IntPtr NativeFieldInfoPtr_office2;

		// Token: 0x04001475 RID: 5237
		private static readonly IntPtr NativeFieldInfoPtr_bunker;

		// Token: 0x04001476 RID: 5238
		private static readonly IntPtr NativeFieldInfoPtr_boat;

		// Token: 0x04001477 RID: 5239
		private static readonly IntPtr NativeFieldInfoPtr_coverQuad;

		// Token: 0x04001478 RID: 5240
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x04001479 RID: 5241
		private static readonly IntPtr NativeFieldInfoPtr_palMats;

		// Token: 0x0400147A RID: 5242
		private static readonly IntPtr NativeFieldInfoPtr_palQuad;

		// Token: 0x0400147B RID: 5243
		private static readonly IntPtr NativeFieldInfoPtr_startflag;

		// Token: 0x0400147C RID: 5244
		private static readonly IntPtr NativeFieldInfoPtr_labTitles;

		// Token: 0x0400147D RID: 5245
		private static readonly IntPtr NativeFieldInfoPtr_officeTitles;

		// Token: 0x0400147E RID: 5246
		private static readonly IntPtr NativeFieldInfoPtr_bunkerTitles;

		// Token: 0x0400147F RID: 5247
		private static readonly IntPtr NativeFieldInfoPtr_boatTitles;

		// Token: 0x04001480 RID: 5248
		private static readonly IntPtr NativeFieldInfoPtr_titles;

		// Token: 0x04001481 RID: 5249
		private static readonly IntPtr NativeFieldInfoPtr_arcadeTitles;

		// Token: 0x04001482 RID: 5250
		private static readonly IntPtr NativeFieldInfoPtr_allTitles;

		// Token: 0x04001483 RID: 5251
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001484 RID: 5252
		private static readonly IntPtr NativeMethodInfoPtr_UpdateShit_Public_Void_0;

		// Token: 0x04001485 RID: 5253
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001486 RID: 5254
		private static readonly IntPtr NativeMethodInfoPtr_ShowTitle_Public_Void_Note_0;

		// Token: 0x04001487 RID: 5255
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
