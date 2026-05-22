using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000067 RID: 103
	public class AlbumMenu : MonoBehaviour
	{
		// Token: 0x06000DBB RID: 3515 RVA: 0x0005CED0 File Offset: 0x0005B0D0
		// Note: this type is marked as 'beforefieldinit'.
		static AlbumMenu()
		{
			Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AlbumMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr);
			AlbumMenu.NativeFieldInfoPtr_trackList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "trackList");
			AlbumMenu.NativeFieldInfoPtr_selectableText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "selectableText");
			AlbumMenu.NativeFieldInfoPtr_selectableTextRends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "selectableTextRends");
			AlbumMenu.NativeFieldInfoPtr_prefString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "prefString");
			AlbumMenu.NativeFieldInfoPtr_select = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "select");
			AlbumMenu.NativeFieldInfoPtr_unlockedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "unlockedColor");
			AlbumMenu.NativeFieldInfoPtr_lockedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "lockedColor");
			AlbumMenu.NativeFieldInfoPtr_menuTexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "menuTexts");
			AlbumMenu.NativeFieldInfoPtr_cover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "cover");
			AlbumMenu.NativeFieldInfoPtr_centered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "centered");
			AlbumMenu.NativeFieldInfoPtr_centerTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "centerTimer");
			AlbumMenu.NativeFieldInfoPtr_centerCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "centerCurve");
			AlbumMenu.NativeFieldInfoPtr_centerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "centerTime");
			AlbumMenu.NativeFieldInfoPtr_defPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "defPos");
			AlbumMenu.NativeFieldInfoPtr_defFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "defFontSize");
			AlbumMenu.NativeFieldInfoPtr_bigFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "bigFontSize");
			AlbumMenu.NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "buttons");
			AlbumMenu.NativeFieldInfoPtr_albumNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "albumNum");
			AlbumMenu.NativeFieldInfoPtr_wiggleMatKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "wiggleMatKey");
			AlbumMenu.NativeFieldInfoPtr_wiggleMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "wiggleMat");
			AlbumMenu.NativeFieldInfoPtr_nonWiggleMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "nonWiggleMat");
			AlbumMenu.NativeFieldInfoPtr_highscoreText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "highscoreText");
			AlbumMenu.NativeFieldInfoPtr_scoreNewLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "scoreNewLine");
			AlbumMenu.NativeFieldInfoPtr_menuNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "menuNum");
			AlbumMenu.NativeFieldInfoPtr_arcadeUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "arcadeUnlocked");
			AlbumMenu.NativeFieldInfoPtr_midRun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "midRun");
			AlbumMenu.NativeFieldInfoPtr_trackHighlightCol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "trackHighlightCol");
			AlbumMenu.NativeFieldInfoPtr_selectableDefCol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "selectableDefCol");
			AlbumMenu.NativeFieldInfoPtr_overriding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "overriding");
			AlbumMenu.NativeFieldInfoPtr_scaleTweening = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "scaleTweening");
			AlbumMenu.NativeFieldInfoPtr_selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "selected");
			AlbumMenu.NativeFieldInfoPtr_frontRends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "frontRends");
			AlbumMenu.NativeFieldInfoPtr_prevSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "prevSelected");
			AlbumMenu.NativeFieldInfoPtr_labback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "labback");
			AlbumMenu.NativeFieldInfoPtr_prevLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "prevLang");
			AlbumMenu.NativeFieldInfoPtr_albumBanana = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "albumBanana");
			AlbumMenu.NativeFieldInfoPtr_stickers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "stickers");
			AlbumMenu.NativeFieldInfoPtr_stickerPrefs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "stickerPrefs");
			AlbumMenu.NativeFieldInfoPtr_prevScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "prevScale");
			AlbumMenu.NativeFieldInfoPtr_prevOverriding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "prevOverriding");
			AlbumMenu.NativeFieldInfoPtr_youSuring = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, "youSuring");
			AlbumMenu.NativeMethodInfoPtr_CheckBanana_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, 100664491);
			AlbumMenu.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, 100664492);
			AlbumMenu.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, 100664493);
			AlbumMenu.NativeMethodInfoPtr_UpdateMaterials_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, 100664494);
			AlbumMenu.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, 100664495);
			AlbumMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr, 100664496);
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x0005D2AC File Offset: 0x0005B4AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 44216, RefRangeEnd = 44218, XrefRangeStart = 44192, XrefRangeEnd = 44216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckBanana()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AlbumMenu.NativeMethodInfoPtr_CheckBanana_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x0005D2E0 File Offset: 0x0005B4E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44218, XrefRangeEnd = 44258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AlbumMenu.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x0005D314 File Offset: 0x0005B514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44258, XrefRangeEnd = 44432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AlbumMenu.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x0005D348 File Offset: 0x0005B548
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 44512, RefRangeEnd = 44514, XrefRangeStart = 44432, XrefRangeEnd = 44512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AlbumMenu.NativeMethodInfoPtr_UpdateMaterials_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x0005D37C File Offset: 0x0005B57C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44514, XrefRangeEnd = 44747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AlbumMenu.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x0005D3B0 File Offset: 0x0005B5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44747, XrefRangeEnd = 44768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AlbumMenu()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AlbumMenu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AlbumMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x0000A668 File Offset: 0x00008868
		public AlbumMenu(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x0005D3EC File Offset: 0x0005B5EC
		// (set) Token: 0x06000DC4 RID: 3524 RVA: 0x0000A671 File Offset: 0x00008871
		public unsafe Il2CppReferenceArray<TextMesh> trackList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_trackList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMesh>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_trackList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06000DC5 RID: 3525 RVA: 0x0005D41C File Offset: 0x0005B61C
		// (set) Token: 0x06000DC6 RID: 3526 RVA: 0x0000A690 File Offset: 0x00008890
		public unsafe List<TextMesh> selectableText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_selectableText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TextMesh>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_selectableText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06000DC7 RID: 3527 RVA: 0x0005D44C File Offset: 0x0005B64C
		// (set) Token: 0x06000DC8 RID: 3528 RVA: 0x0000A6AF File Offset: 0x000088AF
		public unsafe List<MeshRenderer> selectableTextRends
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_selectableTextRends);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_selectableTextRends), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06000DC9 RID: 3529 RVA: 0x0005D47C File Offset: 0x0005B67C
		// (set) Token: 0x06000DCA RID: 3530 RVA: 0x0000A6CE File Offset: 0x000088CE
		public unsafe string prefString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_prefString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_prefString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06000DCB RID: 3531 RVA: 0x0005D4A4 File Offset: 0x0005B6A4
		// (set) Token: 0x06000DCC RID: 3532 RVA: 0x0000A6ED File Offset: 0x000088ED
		public unsafe int select
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_select);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_select)) = value;
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06000DCD RID: 3533 RVA: 0x0005D4CC File Offset: 0x0005B6CC
		// (set) Token: 0x06000DCE RID: 3534 RVA: 0x0000A708 File Offset: 0x00008908
		public unsafe Color unlockedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_unlockedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_unlockedColor)) = value;
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06000DCF RID: 3535 RVA: 0x0005D4F4 File Offset: 0x0005B6F4
		// (set) Token: 0x06000DD0 RID: 3536 RVA: 0x0000A723 File Offset: 0x00008923
		public unsafe Color lockedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_lockedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_lockedColor)) = value;
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x0005D51C File Offset: 0x0005B71C
		// (set) Token: 0x06000DD2 RID: 3538 RVA: 0x0000A73E File Offset: 0x0000893E
		public unsafe Il2CppReferenceArray<TextMesh> menuTexts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_menuTexts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMesh>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_menuTexts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06000DD3 RID: 3539 RVA: 0x0005D54C File Offset: 0x0005B74C
		// (set) Token: 0x06000DD4 RID: 3540 RVA: 0x0000A75D File Offset: 0x0000895D
		public unsafe GameObject cover
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_cover);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_cover), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06000DD5 RID: 3541 RVA: 0x0005D57C File Offset: 0x0005B77C
		// (set) Token: 0x06000DD6 RID: 3542 RVA: 0x0000A77C File Offset: 0x0000897C
		public unsafe bool centered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_centered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_centered)) = value;
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06000DD7 RID: 3543 RVA: 0x0005D5A4 File Offset: 0x0005B7A4
		// (set) Token: 0x06000DD8 RID: 3544 RVA: 0x0000A797 File Offset: 0x00008997
		public unsafe float centerTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_centerTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_centerTimer)) = value;
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06000DD9 RID: 3545 RVA: 0x0005D5CC File Offset: 0x0005B7CC
		// (set) Token: 0x06000DDA RID: 3546 RVA: 0x0000A7B2 File Offset: 0x000089B2
		public unsafe AnimationCurve centerCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_centerCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_centerCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06000DDB RID: 3547 RVA: 0x0005D5FC File Offset: 0x0005B7FC
		// (set) Token: 0x06000DDC RID: 3548 RVA: 0x0000A7D1 File Offset: 0x000089D1
		public unsafe float centerTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_centerTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_centerTime)) = value;
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06000DDD RID: 3549 RVA: 0x0005D624 File Offset: 0x0005B824
		// (set) Token: 0x06000DDE RID: 3550 RVA: 0x0000A7EC File Offset: 0x000089EC
		public unsafe Vector2 defPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_defPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_defPos)) = value;
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06000DDF RID: 3551 RVA: 0x0005D64C File Offset: 0x0005B84C
		// (set) Token: 0x06000DE0 RID: 3552 RVA: 0x0000A807 File Offset: 0x00008A07
		public unsafe int defFontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_defFontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_defFontSize)) = value;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06000DE1 RID: 3553 RVA: 0x0005D674 File Offset: 0x0005B874
		// (set) Token: 0x06000DE2 RID: 3554 RVA: 0x0000A822 File Offset: 0x00008A22
		public unsafe int bigFontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_bigFontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_bigFontSize)) = value;
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06000DE3 RID: 3555 RVA: 0x0005D69C File Offset: 0x0005B89C
		// (set) Token: 0x06000DE4 RID: 3556 RVA: 0x0000A83D File Offset: 0x00008A3D
		public unsafe Il2CppReferenceArray<GameObject> buttons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_buttons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_buttons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06000DE5 RID: 3557 RVA: 0x0005D6CC File Offset: 0x0005B8CC
		// (set) Token: 0x06000DE6 RID: 3558 RVA: 0x0000A85C File Offset: 0x00008A5C
		public unsafe int albumNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_albumNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_albumNum)) = value;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06000DE7 RID: 3559 RVA: 0x0005D6F4 File Offset: 0x0005B8F4
		// (set) Token: 0x06000DE8 RID: 3560 RVA: 0x0000A877 File Offset: 0x00008A77
		public unsafe Il2CppStringArray wiggleMatKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_wiggleMatKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_wiggleMatKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06000DE9 RID: 3561 RVA: 0x0005D724 File Offset: 0x0005B924
		// (set) Token: 0x06000DEA RID: 3562 RVA: 0x0000A896 File Offset: 0x00008A96
		public unsafe Il2CppReferenceArray<Material> wiggleMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_wiggleMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_wiggleMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06000DEB RID: 3563 RVA: 0x0005D754 File Offset: 0x0005B954
		// (set) Token: 0x06000DEC RID: 3564 RVA: 0x0000A8B5 File Offset: 0x00008AB5
		public unsafe Il2CppReferenceArray<Material> nonWiggleMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_nonWiggleMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_nonWiggleMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06000DED RID: 3565 RVA: 0x0005D784 File Offset: 0x0005B984
		// (set) Token: 0x06000DEE RID: 3566 RVA: 0x0000A8D4 File Offset: 0x00008AD4
		public unsafe TextMesh highscoreText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_highscoreText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_highscoreText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06000DEF RID: 3567 RVA: 0x0005D7B4 File Offset: 0x0005B9B4
		// (set) Token: 0x06000DF0 RID: 3568 RVA: 0x0000A8F3 File Offset: 0x00008AF3
		public unsafe bool scoreNewLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_scoreNewLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_scoreNewLine)) = value;
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06000DF1 RID: 3569 RVA: 0x0005D7DC File Offset: 0x0005B9DC
		// (set) Token: 0x06000DF2 RID: 3570 RVA: 0x0000A90E File Offset: 0x00008B0E
		public unsafe int menuNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_menuNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_menuNum)) = value;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06000DF3 RID: 3571 RVA: 0x0005D804 File Offset: 0x0005BA04
		// (set) Token: 0x06000DF4 RID: 3572 RVA: 0x0000A929 File Offset: 0x00008B29
		public unsafe bool arcadeUnlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_arcadeUnlocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_arcadeUnlocked)) = value;
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x0005D82C File Offset: 0x0005BA2C
		// (set) Token: 0x06000DF6 RID: 3574 RVA: 0x0000A944 File Offset: 0x00008B44
		public unsafe bool midRun
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_midRun);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_midRun)) = value;
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06000DF7 RID: 3575 RVA: 0x0005D854 File Offset: 0x0005BA54
		// (set) Token: 0x06000DF8 RID: 3576 RVA: 0x0000A95F File Offset: 0x00008B5F
		public unsafe Color trackHighlightCol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_trackHighlightCol);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_trackHighlightCol)) = value;
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06000DF9 RID: 3577 RVA: 0x0005D87C File Offset: 0x0005BA7C
		// (set) Token: 0x06000DFA RID: 3578 RVA: 0x0000A97A File Offset: 0x00008B7A
		public unsafe Color selectableDefCol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_selectableDefCol);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_selectableDefCol)) = value;
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06000DFB RID: 3579 RVA: 0x0005D8A4 File Offset: 0x0005BAA4
		// (set) Token: 0x06000DFC RID: 3580 RVA: 0x0000A995 File Offset: 0x00008B95
		public unsafe bool overriding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_overriding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_overriding)) = value;
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06000DFD RID: 3581 RVA: 0x0005D8CC File Offset: 0x0005BACC
		// (set) Token: 0x06000DFE RID: 3582 RVA: 0x0000A9B0 File Offset: 0x00008BB0
		public unsafe bool scaleTweening
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_scaleTweening);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_scaleTweening)) = value;
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06000DFF RID: 3583 RVA: 0x0005D8F4 File Offset: 0x0005BAF4
		// (set) Token: 0x06000E00 RID: 3584 RVA: 0x0000A9CB File Offset: 0x00008BCB
		public unsafe bool selected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_selected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_selected)) = value;
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06000E01 RID: 3585 RVA: 0x0005D91C File Offset: 0x0005BB1C
		// (set) Token: 0x06000E02 RID: 3586 RVA: 0x0000A9E6 File Offset: 0x00008BE6
		public unsafe Il2CppReferenceArray<Renderer> frontRends
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_frontRends);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Renderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_frontRends), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06000E03 RID: 3587 RVA: 0x0005D94C File Offset: 0x0005BB4C
		// (set) Token: 0x06000E04 RID: 3588 RVA: 0x0000AA05 File Offset: 0x00008C05
		public unsafe bool prevSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_prevSelected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_prevSelected)) = value;
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06000E05 RID: 3589 RVA: 0x0005D974 File Offset: 0x0005BB74
		// (set) Token: 0x06000E06 RID: 3590 RVA: 0x0000AA20 File Offset: 0x00008C20
		public unsafe Transform labback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_labback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_labback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06000E07 RID: 3591 RVA: 0x0005D9A4 File Offset: 0x0005BBA4
		// (set) Token: 0x06000E08 RID: 3592 RVA: 0x0000AA3F File Offset: 0x00008C3F
		public unsafe string prevLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_prevLang);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_prevLang), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06000E09 RID: 3593 RVA: 0x0005D9CC File Offset: 0x0005BBCC
		// (set) Token: 0x06000E0A RID: 3594 RVA: 0x0000AA5E File Offset: 0x00008C5E
		public unsafe GameObject albumBanana
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_albumBanana);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_albumBanana), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06000E0B RID: 3595 RVA: 0x0005D9FC File Offset: 0x0005BBFC
		// (set) Token: 0x06000E0C RID: 3596 RVA: 0x0000AA7D File Offset: 0x00008C7D
		public unsafe Il2CppReferenceArray<GameObject> stickers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_stickers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_stickers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x0005DA2C File Offset: 0x0005BC2C
		// (set) Token: 0x06000E0E RID: 3598 RVA: 0x0000AA9C File Offset: 0x00008C9C
		public unsafe Il2CppStringArray stickerPrefs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_stickerPrefs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_stickerPrefs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06000E0F RID: 3599 RVA: 0x0005DA5C File Offset: 0x0005BC5C
		// (set) Token: 0x06000E10 RID: 3600 RVA: 0x0000AABB File Offset: 0x00008CBB
		public unsafe float prevScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_prevScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_prevScale)) = value;
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06000E11 RID: 3601 RVA: 0x0005DA84 File Offset: 0x0005BC84
		// (set) Token: 0x06000E12 RID: 3602 RVA: 0x0000AAD6 File Offset: 0x00008CD6
		public unsafe bool prevOverriding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_prevOverriding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_prevOverriding)) = value;
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06000E13 RID: 3603 RVA: 0x0005DAAC File Offset: 0x0005BCAC
		// (set) Token: 0x06000E14 RID: 3604 RVA: 0x0000AAF1 File Offset: 0x00008CF1
		public unsafe bool youSuring
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_youSuring);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlbumMenu.NativeFieldInfoPtr_youSuring)) = value;
			}
		}

		// Token: 0x0400086B RID: 2155
		private static readonly IntPtr NativeFieldInfoPtr_trackList;

		// Token: 0x0400086C RID: 2156
		private static readonly IntPtr NativeFieldInfoPtr_selectableText;

		// Token: 0x0400086D RID: 2157
		private static readonly IntPtr NativeFieldInfoPtr_selectableTextRends;

		// Token: 0x0400086E RID: 2158
		private static readonly IntPtr NativeFieldInfoPtr_prefString;

		// Token: 0x0400086F RID: 2159
		private static readonly IntPtr NativeFieldInfoPtr_select;

		// Token: 0x04000870 RID: 2160
		private static readonly IntPtr NativeFieldInfoPtr_unlockedColor;

		// Token: 0x04000871 RID: 2161
		private static readonly IntPtr NativeFieldInfoPtr_lockedColor;

		// Token: 0x04000872 RID: 2162
		private static readonly IntPtr NativeFieldInfoPtr_menuTexts;

		// Token: 0x04000873 RID: 2163
		private static readonly IntPtr NativeFieldInfoPtr_cover;

		// Token: 0x04000874 RID: 2164
		private static readonly IntPtr NativeFieldInfoPtr_centered;

		// Token: 0x04000875 RID: 2165
		private static readonly IntPtr NativeFieldInfoPtr_centerTimer;

		// Token: 0x04000876 RID: 2166
		private static readonly IntPtr NativeFieldInfoPtr_centerCurve;

		// Token: 0x04000877 RID: 2167
		private static readonly IntPtr NativeFieldInfoPtr_centerTime;

		// Token: 0x04000878 RID: 2168
		private static readonly IntPtr NativeFieldInfoPtr_defPos;

		// Token: 0x04000879 RID: 2169
		private static readonly IntPtr NativeFieldInfoPtr_defFontSize;

		// Token: 0x0400087A RID: 2170
		private static readonly IntPtr NativeFieldInfoPtr_bigFontSize;

		// Token: 0x0400087B RID: 2171
		private static readonly IntPtr NativeFieldInfoPtr_buttons;

		// Token: 0x0400087C RID: 2172
		private static readonly IntPtr NativeFieldInfoPtr_albumNum;

		// Token: 0x0400087D RID: 2173
		private static readonly IntPtr NativeFieldInfoPtr_wiggleMatKey;

		// Token: 0x0400087E RID: 2174
		private static readonly IntPtr NativeFieldInfoPtr_wiggleMat;

		// Token: 0x0400087F RID: 2175
		private static readonly IntPtr NativeFieldInfoPtr_nonWiggleMat;

		// Token: 0x04000880 RID: 2176
		private static readonly IntPtr NativeFieldInfoPtr_highscoreText;

		// Token: 0x04000881 RID: 2177
		private static readonly IntPtr NativeFieldInfoPtr_scoreNewLine;

		// Token: 0x04000882 RID: 2178
		private static readonly IntPtr NativeFieldInfoPtr_menuNum;

		// Token: 0x04000883 RID: 2179
		private static readonly IntPtr NativeFieldInfoPtr_arcadeUnlocked;

		// Token: 0x04000884 RID: 2180
		private static readonly IntPtr NativeFieldInfoPtr_midRun;

		// Token: 0x04000885 RID: 2181
		private static readonly IntPtr NativeFieldInfoPtr_trackHighlightCol;

		// Token: 0x04000886 RID: 2182
		private static readonly IntPtr NativeFieldInfoPtr_selectableDefCol;

		// Token: 0x04000887 RID: 2183
		private static readonly IntPtr NativeFieldInfoPtr_overriding;

		// Token: 0x04000888 RID: 2184
		private static readonly IntPtr NativeFieldInfoPtr_scaleTweening;

		// Token: 0x04000889 RID: 2185
		private static readonly IntPtr NativeFieldInfoPtr_selected;

		// Token: 0x0400088A RID: 2186
		private static readonly IntPtr NativeFieldInfoPtr_frontRends;

		// Token: 0x0400088B RID: 2187
		private static readonly IntPtr NativeFieldInfoPtr_prevSelected;

		// Token: 0x0400088C RID: 2188
		private static readonly IntPtr NativeFieldInfoPtr_labback;

		// Token: 0x0400088D RID: 2189
		private static readonly IntPtr NativeFieldInfoPtr_prevLang;

		// Token: 0x0400088E RID: 2190
		private static readonly IntPtr NativeFieldInfoPtr_albumBanana;

		// Token: 0x0400088F RID: 2191
		private static readonly IntPtr NativeFieldInfoPtr_stickers;

		// Token: 0x04000890 RID: 2192
		private static readonly IntPtr NativeFieldInfoPtr_stickerPrefs;

		// Token: 0x04000891 RID: 2193
		private static readonly IntPtr NativeFieldInfoPtr_prevScale;

		// Token: 0x04000892 RID: 2194
		private static readonly IntPtr NativeFieldInfoPtr_prevOverriding;

		// Token: 0x04000893 RID: 2195
		private static readonly IntPtr NativeFieldInfoPtr_youSuring;

		// Token: 0x04000894 RID: 2196
		private static readonly IntPtr NativeMethodInfoPtr_CheckBanana_Public_Void_0;

		// Token: 0x04000895 RID: 2197
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000896 RID: 2198
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000897 RID: 2199
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterials_Private_Void_0;

		// Token: 0x04000898 RID: 2200
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000899 RID: 2201
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
