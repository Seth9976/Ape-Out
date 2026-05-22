using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001C2 RID: 450
	public class Tags : MonoBehaviour
	{
		// Token: 0x0600316A RID: 12650 RVA: 0x000BC42C File Offset: 0x000BA62C
		// Note: this type is marked as 'beforefieldinit'.
		static Tags()
		{
			Il2CppClassPointerStore<Tags>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Tags");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tags>.NativeClassPtr);
			Tags.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tags>.NativeClassPtr, "player");
			Tags.NativeFieldInfoPtr_hand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tags>.NativeClassPtr, "hand");
			Tags.NativeFieldInfoPtr_enemy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tags>.NativeClassPtr, "enemy");
			Tags.NativeFieldInfoPtr_fat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tags>.NativeClassPtr, "fat");
			Tags.NativeFieldInfoPtr_skinny = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tags>.NativeClassPtr, "skinny");
			Tags.NativeFieldInfoPtr_solid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tags>.NativeClassPtr, "solid");
			Tags.NativeFieldInfoPtr_opaque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tags>.NativeClassPtr, "opaque");
			Tags.NativeFieldInfoPtr_dynamite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tags>.NativeClassPtr, "dynamite");
			Tags.NativeFieldInfoPtr_push = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tags>.NativeClassPtr, "push");
			Tags.NativeFieldInfoPtr_grab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tags>.NativeClassPtr, "grab");
			Tags.NativeFieldInfoPtr_struggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tags>.NativeClassPtr, "struggle");
			Tags.NativeFieldInfoPtr_breakable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tags>.NativeClassPtr, "breakable");
			Tags.NativeFieldInfoPtr_animal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tags>.NativeClassPtr, "animal");
			Tags.NativeFieldInfoPtr_floor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tags>.NativeClassPtr, "floor");
			Tags.NativeFieldInfoPtr_visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tags>.NativeClassPtr, "visible");
			Tags.NativeFieldInfoPtr_dead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tags>.NativeClassPtr, "dead");
			Tags.NativeFieldInfoPtr_permeable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tags>.NativeClassPtr, "permeable");
			Tags.NativeFieldInfoPtr_caged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tags>.NativeClassPtr, "caged");
			Tags.NativeFieldInfoPtr_bigDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tags>.NativeClassPtr, "bigDoor");
			Tags.NativeFieldInfoPtr_superShield = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tags>.NativeClassPtr, "superShield");
			Tags.NativeFieldInfoPtr_soundMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tags>.NativeClassPtr, "soundMaterial");
			Tags.NativeMethodInfoPtr_Get_Public_Static_Tags_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tags>.NativeClassPtr, 100667163);
			Tags.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tags>.NativeClassPtr, 100667164);
			Tags.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tags>.NativeClassPtr, 100667165);
		}

		// Token: 0x0600316B RID: 12651 RVA: 0x000BC63C File Offset: 0x000BA83C
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 85372, RefRangeEnd = 85412, XrefRangeStart = 85322, XrefRangeEnd = 85372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tags Get(GameObject obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tags.NativeMethodInfoPtr_Get_Public_Static_Tags_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tags>(intPtr3) : null;
			}
		}

		// Token: 0x0600316C RID: 12652 RVA: 0x000BC680 File Offset: 0x000BA880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85412, XrefRangeEnd = 85419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tags.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600316D RID: 12653 RVA: 0x000BC6B4 File Offset: 0x000BA8B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tags()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tags>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tags.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600316E RID: 12654 RVA: 0x00021E12 File Offset: 0x00020012
		public Tags(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700118F RID: 4495
		// (get) Token: 0x0600316F RID: 12655 RVA: 0x000BC6F0 File Offset: 0x000BA8F0
		// (set) Token: 0x06003170 RID: 12656 RVA: 0x00021E1B File Offset: 0x0002001B
		public unsafe bool player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_player);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_player)) = value;
			}
		}

		// Token: 0x17001190 RID: 4496
		// (get) Token: 0x06003171 RID: 12657 RVA: 0x000BC718 File Offset: 0x000BA918
		// (set) Token: 0x06003172 RID: 12658 RVA: 0x00021E36 File Offset: 0x00020036
		public unsafe bool hand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_hand);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_hand)) = value;
			}
		}

		// Token: 0x17001191 RID: 4497
		// (get) Token: 0x06003173 RID: 12659 RVA: 0x000BC740 File Offset: 0x000BA940
		// (set) Token: 0x06003174 RID: 12660 RVA: 0x00021E51 File Offset: 0x00020051
		public unsafe bool enemy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_enemy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_enemy)) = value;
			}
		}

		// Token: 0x17001192 RID: 4498
		// (get) Token: 0x06003175 RID: 12661 RVA: 0x000BC768 File Offset: 0x000BA968
		// (set) Token: 0x06003176 RID: 12662 RVA: 0x00021E6C File Offset: 0x0002006C
		public unsafe bool fat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_fat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_fat)) = value;
			}
		}

		// Token: 0x17001193 RID: 4499
		// (get) Token: 0x06003177 RID: 12663 RVA: 0x000BC790 File Offset: 0x000BA990
		// (set) Token: 0x06003178 RID: 12664 RVA: 0x00021E87 File Offset: 0x00020087
		public unsafe bool skinny
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_skinny);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_skinny)) = value;
			}
		}

		// Token: 0x17001194 RID: 4500
		// (get) Token: 0x06003179 RID: 12665 RVA: 0x000BC7B8 File Offset: 0x000BA9B8
		// (set) Token: 0x0600317A RID: 12666 RVA: 0x00021EA2 File Offset: 0x000200A2
		public unsafe bool solid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_solid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_solid)) = value;
			}
		}

		// Token: 0x17001195 RID: 4501
		// (get) Token: 0x0600317B RID: 12667 RVA: 0x000BC7E0 File Offset: 0x000BA9E0
		// (set) Token: 0x0600317C RID: 12668 RVA: 0x00021EBD File Offset: 0x000200BD
		public unsafe bool opaque
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_opaque);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_opaque)) = value;
			}
		}

		// Token: 0x17001196 RID: 4502
		// (get) Token: 0x0600317D RID: 12669 RVA: 0x000BC808 File Offset: 0x000BAA08
		// (set) Token: 0x0600317E RID: 12670 RVA: 0x00021ED8 File Offset: 0x000200D8
		public unsafe bool dynamite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_dynamite);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_dynamite)) = value;
			}
		}

		// Token: 0x17001197 RID: 4503
		// (get) Token: 0x0600317F RID: 12671 RVA: 0x000BC830 File Offset: 0x000BAA30
		// (set) Token: 0x06003180 RID: 12672 RVA: 0x00021EF3 File Offset: 0x000200F3
		public unsafe bool push
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_push);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_push)) = value;
			}
		}

		// Token: 0x17001198 RID: 4504
		// (get) Token: 0x06003181 RID: 12673 RVA: 0x000BC858 File Offset: 0x000BAA58
		// (set) Token: 0x06003182 RID: 12674 RVA: 0x00021F0E File Offset: 0x0002010E
		public unsafe bool grab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_grab);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_grab)) = value;
			}
		}

		// Token: 0x17001199 RID: 4505
		// (get) Token: 0x06003183 RID: 12675 RVA: 0x000BC880 File Offset: 0x000BAA80
		// (set) Token: 0x06003184 RID: 12676 RVA: 0x00021F29 File Offset: 0x00020129
		public unsafe bool struggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_struggle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_struggle)) = value;
			}
		}

		// Token: 0x1700119A RID: 4506
		// (get) Token: 0x06003185 RID: 12677 RVA: 0x000BC8A8 File Offset: 0x000BAAA8
		// (set) Token: 0x06003186 RID: 12678 RVA: 0x00021F44 File Offset: 0x00020144
		public unsafe bool breakable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_breakable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_breakable)) = value;
			}
		}

		// Token: 0x1700119B RID: 4507
		// (get) Token: 0x06003187 RID: 12679 RVA: 0x000BC8D0 File Offset: 0x000BAAD0
		// (set) Token: 0x06003188 RID: 12680 RVA: 0x00021F5F File Offset: 0x0002015F
		public unsafe bool animal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_animal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_animal)) = value;
			}
		}

		// Token: 0x1700119C RID: 4508
		// (get) Token: 0x06003189 RID: 12681 RVA: 0x000BC8F8 File Offset: 0x000BAAF8
		// (set) Token: 0x0600318A RID: 12682 RVA: 0x00021F7A File Offset: 0x0002017A
		public unsafe bool floor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_floor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_floor)) = value;
			}
		}

		// Token: 0x1700119D RID: 4509
		// (get) Token: 0x0600318B RID: 12683 RVA: 0x000BC920 File Offset: 0x000BAB20
		// (set) Token: 0x0600318C RID: 12684 RVA: 0x00021F95 File Offset: 0x00020195
		public unsafe bool visible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_visible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_visible)) = value;
			}
		}

		// Token: 0x1700119E RID: 4510
		// (get) Token: 0x0600318D RID: 12685 RVA: 0x000BC948 File Offset: 0x000BAB48
		// (set) Token: 0x0600318E RID: 12686 RVA: 0x00021FB0 File Offset: 0x000201B0
		public unsafe bool dead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_dead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_dead)) = value;
			}
		}

		// Token: 0x1700119F RID: 4511
		// (get) Token: 0x0600318F RID: 12687 RVA: 0x000BC970 File Offset: 0x000BAB70
		// (set) Token: 0x06003190 RID: 12688 RVA: 0x00021FCB File Offset: 0x000201CB
		public unsafe bool permeable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_permeable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_permeable)) = value;
			}
		}

		// Token: 0x170011A0 RID: 4512
		// (get) Token: 0x06003191 RID: 12689 RVA: 0x000BC998 File Offset: 0x000BAB98
		// (set) Token: 0x06003192 RID: 12690 RVA: 0x00021FE6 File Offset: 0x000201E6
		public unsafe bool caged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_caged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_caged)) = value;
			}
		}

		// Token: 0x170011A1 RID: 4513
		// (get) Token: 0x06003193 RID: 12691 RVA: 0x000BC9C0 File Offset: 0x000BABC0
		// (set) Token: 0x06003194 RID: 12692 RVA: 0x00022001 File Offset: 0x00020201
		public unsafe bool bigDoor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_bigDoor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_bigDoor)) = value;
			}
		}

		// Token: 0x170011A2 RID: 4514
		// (get) Token: 0x06003195 RID: 12693 RVA: 0x000BC9E8 File Offset: 0x000BABE8
		// (set) Token: 0x06003196 RID: 12694 RVA: 0x0002201C File Offset: 0x0002021C
		public unsafe bool superShield
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_superShield);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_superShield)) = value;
			}
		}

		// Token: 0x170011A3 RID: 4515
		// (get) Token: 0x06003197 RID: 12695 RVA: 0x000BCA10 File Offset: 0x000BAC10
		// (set) Token: 0x06003198 RID: 12696 RVA: 0x00022037 File Offset: 0x00020237
		public unsafe Tags.SoundMaterial soundMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_soundMaterial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tags.NativeFieldInfoPtr_soundMaterial)) = value;
			}
		}

		// Token: 0x04001CF7 RID: 7415
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x04001CF8 RID: 7416
		private static readonly IntPtr NativeFieldInfoPtr_hand;

		// Token: 0x04001CF9 RID: 7417
		private static readonly IntPtr NativeFieldInfoPtr_enemy;

		// Token: 0x04001CFA RID: 7418
		private static readonly IntPtr NativeFieldInfoPtr_fat;

		// Token: 0x04001CFB RID: 7419
		private static readonly IntPtr NativeFieldInfoPtr_skinny;

		// Token: 0x04001CFC RID: 7420
		private static readonly IntPtr NativeFieldInfoPtr_solid;

		// Token: 0x04001CFD RID: 7421
		private static readonly IntPtr NativeFieldInfoPtr_opaque;

		// Token: 0x04001CFE RID: 7422
		private static readonly IntPtr NativeFieldInfoPtr_dynamite;

		// Token: 0x04001CFF RID: 7423
		private static readonly IntPtr NativeFieldInfoPtr_push;

		// Token: 0x04001D00 RID: 7424
		private static readonly IntPtr NativeFieldInfoPtr_grab;

		// Token: 0x04001D01 RID: 7425
		private static readonly IntPtr NativeFieldInfoPtr_struggle;

		// Token: 0x04001D02 RID: 7426
		private static readonly IntPtr NativeFieldInfoPtr_breakable;

		// Token: 0x04001D03 RID: 7427
		private static readonly IntPtr NativeFieldInfoPtr_animal;

		// Token: 0x04001D04 RID: 7428
		private static readonly IntPtr NativeFieldInfoPtr_floor;

		// Token: 0x04001D05 RID: 7429
		private static readonly IntPtr NativeFieldInfoPtr_visible;

		// Token: 0x04001D06 RID: 7430
		private static readonly IntPtr NativeFieldInfoPtr_dead;

		// Token: 0x04001D07 RID: 7431
		private static readonly IntPtr NativeFieldInfoPtr_permeable;

		// Token: 0x04001D08 RID: 7432
		private static readonly IntPtr NativeFieldInfoPtr_caged;

		// Token: 0x04001D09 RID: 7433
		private static readonly IntPtr NativeFieldInfoPtr_bigDoor;

		// Token: 0x04001D0A RID: 7434
		private static readonly IntPtr NativeFieldInfoPtr_superShield;

		// Token: 0x04001D0B RID: 7435
		private static readonly IntPtr NativeFieldInfoPtr_soundMaterial;

		// Token: 0x04001D0C RID: 7436
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_Tags_GameObject_0;

		// Token: 0x04001D0D RID: 7437
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04001D0E RID: 7438
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000353 RID: 851
		[OriginalName("Assembly-CSharp.dll", "", "SoundMaterial")]
		public enum SoundMaterial
		{
			// Token: 0x04003735 RID: 14133
			Wood,
			// Token: 0x04003736 RID: 14134
			ThickMetal,
			// Token: 0x04003737 RID: 14135
			ThinMetal,
			// Token: 0x04003738 RID: 14136
			DryWall,
			// Token: 0x04003739 RID: 14137
			Tree,
			// Token: 0x0400373A RID: 14138
			Rock,
			// Token: 0x0400373B RID: 14139
			Appliance,
			// Token: 0x0400373C RID: 14140
			Concrete,
			// Token: 0x0400373D RID: 14141
			Bars,
			// Token: 0x0400373E RID: 14142
			Fence,
			// Token: 0x0400373F RID: 14143
			Flesh,
			// Token: 0x04003740 RID: 14144
			Bed
		}
	}
}
