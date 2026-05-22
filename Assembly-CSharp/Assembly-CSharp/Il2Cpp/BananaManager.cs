using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200005C RID: 92
	public class BananaManager : MonoBehaviour
	{
		// Token: 0x06000CE2 RID: 3298 RVA: 0x0005ADF4 File Offset: 0x00058FF4
		// Note: this type is marked as 'beforefieldinit'.
		static BananaManager()
		{
			Il2CppClassPointerStore<BananaManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BananaManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BananaManager>.NativeClassPtr);
			BananaManager.NativeFieldInfoPtr_frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BananaManager>.NativeClassPtr, "frame");
			BananaManager.NativeFieldInfoPtr_nOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BananaManager>.NativeClassPtr, "nOffset");
			BananaManager.NativeFieldInfoPtr_matArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BananaManager>.NativeClassPtr, "matArr");
			BananaManager.NativeFieldInfoPtr_bananas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BananaManager>.NativeClassPtr, "bananas");
			BananaManager.NativeFieldInfoPtr_guard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BananaManager>.NativeClassPtr, "guard");
			BananaManager.NativeFieldInfoPtr_bananasEaten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BananaManager>.NativeClassPtr, "bananasEaten");
			BananaManager.NativeFieldInfoPtr_playerWon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BananaManager>.NativeClassPtr, "playerWon");
			BananaManager.NativeFieldInfoPtr_bloodCam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BananaManager>.NativeClassPtr, "bloodCam");
			BananaManager.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BananaManager>.NativeClassPtr, "source");
			BananaManager.NativeFieldInfoPtr_chomp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BananaManager>.NativeClassPtr, "chomp");
			BananaManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BananaManager>.NativeClassPtr, 100664438);
			BananaManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BananaManager>.NativeClassPtr, 100664439);
			BananaManager.NativeMethodInfoPtr_Eat_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BananaManager>.NativeClassPtr, 100664440);
			BananaManager.NativeMethodInfoPtr_PlayerWin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BananaManager>.NativeClassPtr, 100664441);
			BananaManager.NativeMethodInfoPtr__EatBananas_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BananaManager>.NativeClassPtr, 100664442);
			BananaManager.NativeMethodInfoPtr__PlayerWin_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BananaManager>.NativeClassPtr, 100664443);
			BananaManager.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BananaManager>.NativeClassPtr, 100664444);
			BananaManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BananaManager>.NativeClassPtr, 100664445);
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x0005AF8C File Offset: 0x0005918C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43561, XrefRangeEnd = 43566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BananaManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x0005AFC0 File Offset: 0x000591C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43566, XrefRangeEnd = 43579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BananaManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x0005AFF4 File Offset: 0x000591F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43692, RefRangeEnd = 43693, XrefRangeStart = 43579, XrefRangeEnd = 43692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Eat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BananaManager.NativeMethodInfoPtr_Eat_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x0005B028 File Offset: 0x00059228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43693, XrefRangeEnd = 43697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerWin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BananaManager.NativeMethodInfoPtr_PlayerWin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x0005B05C File Offset: 0x0005925C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43697, XrefRangeEnd = 43700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator _EatBananas()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BananaManager.NativeMethodInfoPtr__EatBananas_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x0005B09C File Offset: 0x0005929C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43700, XrefRangeEnd = 43703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator _PlayerWin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BananaManager.NativeMethodInfoPtr__PlayerWin_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x0005B0DC File Offset: 0x000592DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43703, XrefRangeEnd = 43709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BananaManager.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x0005B110 File Offset: 0x00059310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BananaManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BananaManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BananaManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x00009CC5 File Offset: 0x00007EC5
		public BananaManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000CEC RID: 3308 RVA: 0x0005B14C File Offset: 0x0005934C
		// (set) Token: 0x06000CED RID: 3309 RVA: 0x00009CCE File Offset: 0x00007ECE
		public unsafe int frame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BananaManager.NativeFieldInfoPtr_frame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BananaManager.NativeFieldInfoPtr_frame)) = value;
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000CEE RID: 3310 RVA: 0x0005B174 File Offset: 0x00059374
		// (set) Token: 0x06000CEF RID: 3311 RVA: 0x00009CE9 File Offset: 0x00007EE9
		public unsafe Vector4 nOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BananaManager.NativeFieldInfoPtr_nOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BananaManager.NativeFieldInfoPtr_nOffset)) = value;
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x0005B19C File Offset: 0x0005939C
		// (set) Token: 0x06000CF1 RID: 3313 RVA: 0x00009D04 File Offset: 0x00007F04
		public unsafe Il2CppReferenceArray<Material> matArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BananaManager.NativeFieldInfoPtr_matArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BananaManager.NativeFieldInfoPtr_matArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000CF2 RID: 3314 RVA: 0x0005B1CC File Offset: 0x000593CC
		// (set) Token: 0x06000CF3 RID: 3315 RVA: 0x00009D23 File Offset: 0x00007F23
		public unsafe Il2CppReferenceArray<GameObject> bananas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BananaManager.NativeFieldInfoPtr_bananas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BananaManager.NativeFieldInfoPtr_bananas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000CF4 RID: 3316 RVA: 0x0005B1FC File Offset: 0x000593FC
		// (set) Token: 0x06000CF5 RID: 3317 RVA: 0x00009D42 File Offset: 0x00007F42
		public unsafe UnarmedGuard guard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BananaManager.NativeFieldInfoPtr_guard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnarmedGuard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BananaManager.NativeFieldInfoPtr_guard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x0005B22C File Offset: 0x0005942C
		// (set) Token: 0x06000CF7 RID: 3319 RVA: 0x00009D61 File Offset: 0x00007F61
		public unsafe bool bananasEaten
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BananaManager.NativeFieldInfoPtr_bananasEaten);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BananaManager.NativeFieldInfoPtr_bananasEaten)) = value;
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000CF8 RID: 3320 RVA: 0x0005B254 File Offset: 0x00059454
		// (set) Token: 0x06000CF9 RID: 3321 RVA: 0x00009D7C File Offset: 0x00007F7C
		public unsafe bool playerWon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BananaManager.NativeFieldInfoPtr_playerWon);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BananaManager.NativeFieldInfoPtr_playerWon)) = value;
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000CFA RID: 3322 RVA: 0x0005B27C File Offset: 0x0005947C
		// (set) Token: 0x06000CFB RID: 3323 RVA: 0x00009D97 File Offset: 0x00007F97
		public unsafe Camera bloodCam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BananaManager.NativeFieldInfoPtr_bloodCam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BananaManager.NativeFieldInfoPtr_bloodCam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000CFC RID: 3324 RVA: 0x0005B2AC File Offset: 0x000594AC
		// (set) Token: 0x06000CFD RID: 3325 RVA: 0x00009DB6 File Offset: 0x00007FB6
		public unsafe AudioSource source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BananaManager.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BananaManager.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000CFE RID: 3326 RVA: 0x0005B2DC File Offset: 0x000594DC
		// (set) Token: 0x06000CFF RID: 3327 RVA: 0x00009DD5 File Offset: 0x00007FD5
		public unsafe AudioClip chomp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BananaManager.NativeFieldInfoPtr_chomp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BananaManager.NativeFieldInfoPtr_chomp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007E9 RID: 2025
		private static readonly IntPtr NativeFieldInfoPtr_frame;

		// Token: 0x040007EA RID: 2026
		private static readonly IntPtr NativeFieldInfoPtr_nOffset;

		// Token: 0x040007EB RID: 2027
		private static readonly IntPtr NativeFieldInfoPtr_matArr;

		// Token: 0x040007EC RID: 2028
		private static readonly IntPtr NativeFieldInfoPtr_bananas;

		// Token: 0x040007ED RID: 2029
		private static readonly IntPtr NativeFieldInfoPtr_guard;

		// Token: 0x040007EE RID: 2030
		private static readonly IntPtr NativeFieldInfoPtr_bananasEaten;

		// Token: 0x040007EF RID: 2031
		private static readonly IntPtr NativeFieldInfoPtr_playerWon;

		// Token: 0x040007F0 RID: 2032
		private static readonly IntPtr NativeFieldInfoPtr_bloodCam;

		// Token: 0x040007F1 RID: 2033
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x040007F2 RID: 2034
		private static readonly IntPtr NativeFieldInfoPtr_chomp;

		// Token: 0x040007F3 RID: 2035
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040007F4 RID: 2036
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040007F5 RID: 2037
		private static readonly IntPtr NativeMethodInfoPtr_Eat_Public_Void_0;

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeMethodInfoPtr_PlayerWin_Public_Void_0;

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeMethodInfoPtr__EatBananas_Private_IEnumerator_0;

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeMethodInfoPtr__PlayerWin_Private_IEnumerator_0;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002CF RID: 719
		[ObfuscatedName("BananaManager+<_EatBananas>d__14")]
		public sealed class __EatBananas_d__14 : global::Il2CppSystem.Object
		{
			// Token: 0x06004CAC RID: 19628 RVA: 0x0011A010 File Offset: 0x00118210
			// Note: this type is marked as 'beforefieldinit'.
			static __EatBananas_d__14()
			{
				Il2CppClassPointerStore<BananaManager.__EatBananas_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BananaManager>.NativeClassPtr, "<_EatBananas>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BananaManager.__EatBananas_d__14>.NativeClassPtr);
				BananaManager.__EatBananas_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BananaManager.__EatBananas_d__14>.NativeClassPtr, "<>1__state");
				BananaManager.__EatBananas_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BananaManager.__EatBananas_d__14>.NativeClassPtr, "<>2__current");
				BananaManager.__EatBananas_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BananaManager.__EatBananas_d__14>.NativeClassPtr, "<>4__this");
				BananaManager.__EatBananas_d__14.NativeFieldInfoPtr__bananasLeft_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BananaManager.__EatBananas_d__14>.NativeClassPtr, "<bananasLeft>5__2");
				BananaManager.__EatBananas_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BananaManager.__EatBananas_d__14>.NativeClassPtr, 100664446);
				BananaManager.__EatBananas_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BananaManager.__EatBananas_d__14>.NativeClassPtr, 100664447);
				BananaManager.__EatBananas_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BananaManager.__EatBananas_d__14>.NativeClassPtr, 100664448);
				BananaManager.__EatBananas_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BananaManager.__EatBananas_d__14>.NativeClassPtr, 100664449);
				BananaManager.__EatBananas_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BananaManager.__EatBananas_d__14>.NativeClassPtr, 100664450);
				BananaManager.__EatBananas_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BananaManager.__EatBananas_d__14>.NativeClassPtr, 100664451);
			}

			// Token: 0x06004CAD RID: 19629 RVA: 0x0011A104 File Offset: 0x00118304
			[CallerCount(0)]
			public unsafe __EatBananas_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BananaManager.__EatBananas_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BananaManager.__EatBananas_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004CAE RID: 19630 RVA: 0x0011A14C File Offset: 0x0011834C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BananaManager.__EatBananas_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004CAF RID: 19631 RVA: 0x0011A180 File Offset: 0x00118380
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43548, XrefRangeEnd = 43550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BananaManager.__EatBananas_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001BF2 RID: 7154
			// (get) Token: 0x06004CB0 RID: 19632 RVA: 0x0011A1BC File Offset: 0x001183BC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BananaManager.__EatBananas_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004CB1 RID: 19633 RVA: 0x0011A1FC File Offset: 0x001183FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43550, XrefRangeEnd = 43555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BananaManager.__EatBananas_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001BF3 RID: 7155
			// (get) Token: 0x06004CB2 RID: 19634 RVA: 0x0011A230 File Offset: 0x00118430
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BananaManager.__EatBananas_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004CB3 RID: 19635 RVA: 0x0002D2AD File Offset: 0x0002B4AD
			public __EatBananas_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BEE RID: 7150
			// (get) Token: 0x06004CB4 RID: 19636 RVA: 0x0011A270 File Offset: 0x00118470
			// (set) Token: 0x06004CB5 RID: 19637 RVA: 0x0002D2B6 File Offset: 0x0002B4B6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BananaManager.__EatBananas_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BananaManager.__EatBananas_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001BEF RID: 7151
			// (get) Token: 0x06004CB6 RID: 19638 RVA: 0x0011A298 File Offset: 0x00118498
			// (set) Token: 0x06004CB7 RID: 19639 RVA: 0x0002D2D1 File Offset: 0x0002B4D1
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BananaManager.__EatBananas_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BananaManager.__EatBananas_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BF0 RID: 7152
			// (get) Token: 0x06004CB8 RID: 19640 RVA: 0x0011A2C8 File Offset: 0x001184C8
			// (set) Token: 0x06004CB9 RID: 19641 RVA: 0x0002D2F0 File Offset: 0x0002B4F0
			public unsafe BananaManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BananaManager.__EatBananas_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BananaManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BananaManager.__EatBananas_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BF1 RID: 7153
			// (get) Token: 0x06004CBA RID: 19642 RVA: 0x0011A2F8 File Offset: 0x001184F8
			// (set) Token: 0x06004CBB RID: 19643 RVA: 0x0002D30F File Offset: 0x0002B50F
			public unsafe int _bananasLeft_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BananaManager.__EatBananas_d__14.NativeFieldInfoPtr__bananasLeft_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BananaManager.__EatBananas_d__14.NativeFieldInfoPtr__bananasLeft_5__2)) = value;
				}
			}

			// Token: 0x04003236 RID: 12854
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003237 RID: 12855
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003238 RID: 12856
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003239 RID: 12857
			private static readonly IntPtr NativeFieldInfoPtr__bananasLeft_5__2;

			// Token: 0x0400323A RID: 12858
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400323B RID: 12859
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400323C RID: 12860
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400323D RID: 12861
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400323E RID: 12862
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400323F RID: 12863
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020002D0 RID: 720
		[ObfuscatedName("BananaManager+<_PlayerWin>d__15")]
		public sealed class __PlayerWin_d__15 : global::Il2CppSystem.Object
		{
			// Token: 0x06004CBC RID: 19644 RVA: 0x0011A320 File Offset: 0x00118520
			// Note: this type is marked as 'beforefieldinit'.
			static __PlayerWin_d__15()
			{
				Il2CppClassPointerStore<BananaManager.__PlayerWin_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BananaManager>.NativeClassPtr, "<_PlayerWin>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BananaManager.__PlayerWin_d__15>.NativeClassPtr);
				BananaManager.__PlayerWin_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BananaManager.__PlayerWin_d__15>.NativeClassPtr, "<>1__state");
				BananaManager.__PlayerWin_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BananaManager.__PlayerWin_d__15>.NativeClassPtr, "<>2__current");
				BananaManager.__PlayerWin_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BananaManager.__PlayerWin_d__15>.NativeClassPtr, "<>4__this");
				BananaManager.__PlayerWin_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BananaManager.__PlayerWin_d__15>.NativeClassPtr, 100664452);
				BananaManager.__PlayerWin_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BananaManager.__PlayerWin_d__15>.NativeClassPtr, 100664453);
				BananaManager.__PlayerWin_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BananaManager.__PlayerWin_d__15>.NativeClassPtr, 100664454);
				BananaManager.__PlayerWin_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BananaManager.__PlayerWin_d__15>.NativeClassPtr, 100664455);
				BananaManager.__PlayerWin_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BananaManager.__PlayerWin_d__15>.NativeClassPtr, 100664456);
				BananaManager.__PlayerWin_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BananaManager.__PlayerWin_d__15>.NativeClassPtr, 100664457);
			}

			// Token: 0x06004CBD RID: 19645 RVA: 0x0011A400 File Offset: 0x00118600
			[CallerCount(0)]
			public unsafe __PlayerWin_d__15(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BananaManager.__PlayerWin_d__15>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BananaManager.__PlayerWin_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004CBE RID: 19646 RVA: 0x0011A448 File Offset: 0x00118648
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BananaManager.__PlayerWin_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004CBF RID: 19647 RVA: 0x0011A47C File Offset: 0x0011867C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43555, XrefRangeEnd = 43556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BananaManager.__PlayerWin_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001BF7 RID: 7159
			// (get) Token: 0x06004CC0 RID: 19648 RVA: 0x0011A4B8 File Offset: 0x001186B8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BananaManager.__PlayerWin_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004CC1 RID: 19649 RVA: 0x0011A4F8 File Offset: 0x001186F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43556, XrefRangeEnd = 43561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BananaManager.__PlayerWin_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001BF8 RID: 7160
			// (get) Token: 0x06004CC2 RID: 19650 RVA: 0x0011A52C File Offset: 0x0011872C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BananaManager.__PlayerWin_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004CC3 RID: 19651 RVA: 0x0002D32A File Offset: 0x0002B52A
			public __PlayerWin_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BF4 RID: 7156
			// (get) Token: 0x06004CC4 RID: 19652 RVA: 0x0011A56C File Offset: 0x0011876C
			// (set) Token: 0x06004CC5 RID: 19653 RVA: 0x0002D333 File Offset: 0x0002B533
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BananaManager.__PlayerWin_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BananaManager.__PlayerWin_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001BF5 RID: 7157
			// (get) Token: 0x06004CC6 RID: 19654 RVA: 0x0011A594 File Offset: 0x00118794
			// (set) Token: 0x06004CC7 RID: 19655 RVA: 0x0002D34E File Offset: 0x0002B54E
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BananaManager.__PlayerWin_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BananaManager.__PlayerWin_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BF6 RID: 7158
			// (get) Token: 0x06004CC8 RID: 19656 RVA: 0x0011A5C4 File Offset: 0x001187C4
			// (set) Token: 0x06004CC9 RID: 19657 RVA: 0x0002D36D File Offset: 0x0002B56D
			public unsafe BananaManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BananaManager.__PlayerWin_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BananaManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BananaManager.__PlayerWin_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003240 RID: 12864
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003241 RID: 12865
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003242 RID: 12866
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003243 RID: 12867
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003244 RID: 12868
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003245 RID: 12869
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003246 RID: 12870
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003247 RID: 12871
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003248 RID: 12872
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
