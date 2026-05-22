using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200014C RID: 332
	[Serializable]
	public class Pallete : global::Il2CppSystem.Object
	{
		// Token: 0x06002808 RID: 10248 RVA: 0x000A31E4 File Offset: 0x000A13E4
		// Note: this type is marked as 'beforefieldinit'.
		static Pallete()
		{
			Il2CppClassPointerStore<Pallete>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Pallete");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pallete>.NativeClassPtr);
			Pallete.NativeFieldInfoPtr_floor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallete>.NativeClassPtr, "floor");
			Pallete.NativeFieldInfoPtr_floorBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallete>.NativeClassPtr, "floorBG");
			Pallete.NativeFieldInfoPtr_wall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallete>.NativeClassPtr, "wall");
			Pallete.NativeFieldInfoPtr_wallBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallete>.NativeClassPtr, "wallBG");
			Pallete.NativeFieldInfoPtr_guard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallete>.NativeClassPtr, "guard");
			Pallete.NativeFieldInfoPtr_smoke = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallete>.NativeClassPtr, "smoke");
			Pallete.NativeFieldInfoPtr_door = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallete>.NativeClassPtr, "door");
			Pallete.NativeFieldInfoPtr_doorBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallete>.NativeClassPtr, "doorBG");
			Pallete.NativeFieldInfoPtr_glass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallete>.NativeClassPtr, "glass");
			Pallete.NativeFieldInfoPtr_cage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallete>.NativeClassPtr, "cage");
			Pallete.NativeFieldInfoPtr_ape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallete>.NativeClassPtr, "ape");
			Pallete.NativeFieldInfoPtr_apeBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallete>.NativeClassPtr, "apeBlood");
			Pallete.NativeFieldInfoPtr_table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallete>.NativeClassPtr, "table");
			Pallete.NativeFieldInfoPtr_blood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallete>.NativeClassPtr, "blood");
			Pallete.NativeFieldInfoPtr_bloodBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallete>.NativeClassPtr, "bloodBG");
			Pallete.NativeFieldInfoPtr_flash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallete>.NativeClassPtr, "flash");
			Pallete.NativeFieldInfoPtr_flashBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallete>.NativeClassPtr, "flashBG");
			Pallete.NativeFieldInfoPtr_gun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallete>.NativeClassPtr, "gun");
			Pallete.NativeFieldInfoPtr_vest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallete>.NativeClassPtr, "vest");
			Pallete.NativeFieldInfoPtr_fireBackpack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallete>.NativeClassPtr, "fireBackpack");
			Pallete.NativeFieldInfoPtr_colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallete>.NativeClassPtr, "colors");
			Pallete.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallete>.NativeClassPtr, 100666483);
		}

		// Token: 0x06002809 RID: 10249 RVA: 0x000A33CC File Offset: 0x000A15CC
		[CallerCount(0)]
		public unsafe Pallete()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pallete>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallete.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600280A RID: 10250 RVA: 0x0001BE85 File Offset: 0x0001A085
		public Pallete(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x0600280B RID: 10251 RVA: 0x000A3408 File Offset: 0x000A1608
		// (set) Token: 0x0600280C RID: 10252 RVA: 0x0001BE8E File Offset: 0x0001A08E
		public unsafe Color floor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_floor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_floor)) = value;
			}
		}

		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x0600280D RID: 10253 RVA: 0x000A3430 File Offset: 0x000A1630
		// (set) Token: 0x0600280E RID: 10254 RVA: 0x0001BEA9 File Offset: 0x0001A0A9
		public unsafe Color floorBG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_floorBG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_floorBG)) = value;
			}
		}

		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x0600280F RID: 10255 RVA: 0x000A3458 File Offset: 0x000A1658
		// (set) Token: 0x06002810 RID: 10256 RVA: 0x0001BEC4 File Offset: 0x0001A0C4
		public unsafe Color wall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_wall);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_wall)) = value;
			}
		}

		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x06002811 RID: 10257 RVA: 0x000A3480 File Offset: 0x000A1680
		// (set) Token: 0x06002812 RID: 10258 RVA: 0x0001BEDF File Offset: 0x0001A0DF
		public unsafe Color wallBG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_wallBG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_wallBG)) = value;
			}
		}

		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x06002813 RID: 10259 RVA: 0x000A34A8 File Offset: 0x000A16A8
		// (set) Token: 0x06002814 RID: 10260 RVA: 0x0001BEFA File Offset: 0x0001A0FA
		public unsafe Color guard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_guard);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_guard)) = value;
			}
		}

		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x06002815 RID: 10261 RVA: 0x000A34D0 File Offset: 0x000A16D0
		// (set) Token: 0x06002816 RID: 10262 RVA: 0x0001BF15 File Offset: 0x0001A115
		public unsafe Color smoke
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_smoke);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_smoke)) = value;
			}
		}

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x06002817 RID: 10263 RVA: 0x000A34F8 File Offset: 0x000A16F8
		// (set) Token: 0x06002818 RID: 10264 RVA: 0x0001BF30 File Offset: 0x0001A130
		public unsafe Color door
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_door);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_door)) = value;
			}
		}

		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x06002819 RID: 10265 RVA: 0x000A3520 File Offset: 0x000A1720
		// (set) Token: 0x0600281A RID: 10266 RVA: 0x0001BF4B File Offset: 0x0001A14B
		public unsafe Color doorBG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_doorBG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_doorBG)) = value;
			}
		}

		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x0600281B RID: 10267 RVA: 0x000A3548 File Offset: 0x000A1748
		// (set) Token: 0x0600281C RID: 10268 RVA: 0x0001BF66 File Offset: 0x0001A166
		public unsafe Color glass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_glass);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_glass)) = value;
			}
		}

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x0600281D RID: 10269 RVA: 0x000A3570 File Offset: 0x000A1770
		// (set) Token: 0x0600281E RID: 10270 RVA: 0x0001BF81 File Offset: 0x0001A181
		public unsafe Color cage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_cage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_cage)) = value;
			}
		}

		// Token: 0x17000E75 RID: 3701
		// (get) Token: 0x0600281F RID: 10271 RVA: 0x000A3598 File Offset: 0x000A1798
		// (set) Token: 0x06002820 RID: 10272 RVA: 0x0001BF9C File Offset: 0x0001A19C
		public unsafe Color ape
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_ape);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_ape)) = value;
			}
		}

		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x06002821 RID: 10273 RVA: 0x000A35C0 File Offset: 0x000A17C0
		// (set) Token: 0x06002822 RID: 10274 RVA: 0x0001BFB7 File Offset: 0x0001A1B7
		public unsafe Color apeBlood
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_apeBlood);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_apeBlood)) = value;
			}
		}

		// Token: 0x17000E77 RID: 3703
		// (get) Token: 0x06002823 RID: 10275 RVA: 0x000A35E8 File Offset: 0x000A17E8
		// (set) Token: 0x06002824 RID: 10276 RVA: 0x0001BFD2 File Offset: 0x0001A1D2
		public unsafe Color table
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_table);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_table)) = value;
			}
		}

		// Token: 0x17000E78 RID: 3704
		// (get) Token: 0x06002825 RID: 10277 RVA: 0x000A3610 File Offset: 0x000A1810
		// (set) Token: 0x06002826 RID: 10278 RVA: 0x0001BFED File Offset: 0x0001A1ED
		public unsafe Color blood
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_blood);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_blood)) = value;
			}
		}

		// Token: 0x17000E79 RID: 3705
		// (get) Token: 0x06002827 RID: 10279 RVA: 0x000A3638 File Offset: 0x000A1838
		// (set) Token: 0x06002828 RID: 10280 RVA: 0x0001C008 File Offset: 0x0001A208
		public unsafe Color bloodBG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_bloodBG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_bloodBG)) = value;
			}
		}

		// Token: 0x17000E7A RID: 3706
		// (get) Token: 0x06002829 RID: 10281 RVA: 0x000A3660 File Offset: 0x000A1860
		// (set) Token: 0x0600282A RID: 10282 RVA: 0x0001C023 File Offset: 0x0001A223
		public unsafe Color flash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_flash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_flash)) = value;
			}
		}

		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x0600282B RID: 10283 RVA: 0x000A3688 File Offset: 0x000A1888
		// (set) Token: 0x0600282C RID: 10284 RVA: 0x0001C03E File Offset: 0x0001A23E
		public unsafe Color flashBG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_flashBG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_flashBG)) = value;
			}
		}

		// Token: 0x17000E7C RID: 3708
		// (get) Token: 0x0600282D RID: 10285 RVA: 0x000A36B0 File Offset: 0x000A18B0
		// (set) Token: 0x0600282E RID: 10286 RVA: 0x0001C059 File Offset: 0x0001A259
		public unsafe Color gun
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_gun);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_gun)) = value;
			}
		}

		// Token: 0x17000E7D RID: 3709
		// (get) Token: 0x0600282F RID: 10287 RVA: 0x000A36D8 File Offset: 0x000A18D8
		// (set) Token: 0x06002830 RID: 10288 RVA: 0x0001C074 File Offset: 0x0001A274
		public unsafe Color vest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_vest);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_vest)) = value;
			}
		}

		// Token: 0x17000E7E RID: 3710
		// (get) Token: 0x06002831 RID: 10289 RVA: 0x000A3700 File Offset: 0x000A1900
		// (set) Token: 0x06002832 RID: 10290 RVA: 0x0001C08F File Offset: 0x0001A28F
		public unsafe Color fireBackpack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_fireBackpack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_fireBackpack)) = value;
			}
		}

		// Token: 0x17000E7F RID: 3711
		// (get) Token: 0x06002833 RID: 10291 RVA: 0x000A3728 File Offset: 0x000A1928
		// (set) Token: 0x06002834 RID: 10292 RVA: 0x0001C0AA File Offset: 0x0001A2AA
		public unsafe Il2CppStructArray<Color> colors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_colors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallete.NativeFieldInfoPtr_colors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001790 RID: 6032
		private static readonly IntPtr NativeFieldInfoPtr_floor;

		// Token: 0x04001791 RID: 6033
		private static readonly IntPtr NativeFieldInfoPtr_floorBG;

		// Token: 0x04001792 RID: 6034
		private static readonly IntPtr NativeFieldInfoPtr_wall;

		// Token: 0x04001793 RID: 6035
		private static readonly IntPtr NativeFieldInfoPtr_wallBG;

		// Token: 0x04001794 RID: 6036
		private static readonly IntPtr NativeFieldInfoPtr_guard;

		// Token: 0x04001795 RID: 6037
		private static readonly IntPtr NativeFieldInfoPtr_smoke;

		// Token: 0x04001796 RID: 6038
		private static readonly IntPtr NativeFieldInfoPtr_door;

		// Token: 0x04001797 RID: 6039
		private static readonly IntPtr NativeFieldInfoPtr_doorBG;

		// Token: 0x04001798 RID: 6040
		private static readonly IntPtr NativeFieldInfoPtr_glass;

		// Token: 0x04001799 RID: 6041
		private static readonly IntPtr NativeFieldInfoPtr_cage;

		// Token: 0x0400179A RID: 6042
		private static readonly IntPtr NativeFieldInfoPtr_ape;

		// Token: 0x0400179B RID: 6043
		private static readonly IntPtr NativeFieldInfoPtr_apeBlood;

		// Token: 0x0400179C RID: 6044
		private static readonly IntPtr NativeFieldInfoPtr_table;

		// Token: 0x0400179D RID: 6045
		private static readonly IntPtr NativeFieldInfoPtr_blood;

		// Token: 0x0400179E RID: 6046
		private static readonly IntPtr NativeFieldInfoPtr_bloodBG;

		// Token: 0x0400179F RID: 6047
		private static readonly IntPtr NativeFieldInfoPtr_flash;

		// Token: 0x040017A0 RID: 6048
		private static readonly IntPtr NativeFieldInfoPtr_flashBG;

		// Token: 0x040017A1 RID: 6049
		private static readonly IntPtr NativeFieldInfoPtr_gun;

		// Token: 0x040017A2 RID: 6050
		private static readonly IntPtr NativeFieldInfoPtr_vest;

		// Token: 0x040017A3 RID: 6051
		private static readonly IntPtr NativeFieldInfoPtr_fireBackpack;

		// Token: 0x040017A4 RID: 6052
		private static readonly IntPtr NativeFieldInfoPtr_colors;

		// Token: 0x040017A5 RID: 6053
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
