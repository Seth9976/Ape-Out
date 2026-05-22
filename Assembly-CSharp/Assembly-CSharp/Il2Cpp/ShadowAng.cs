using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000184 RID: 388
	public class ShadowAng : global::Il2CppSystem.Object
	{
		// Token: 0x06002E07 RID: 11783 RVA: 0x000B3404 File Offset: 0x000B1604
		// Note: this type is marked as 'beforefieldinit'.
		static ShadowAng()
		{
			Il2CppClassPointerStore<ShadowAng>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ShadowAng");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowAng>.NativeClassPtr);
			ShadowAng.NativeFieldInfoPtr_ang1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowAng>.NativeClassPtr, "ang1");
			ShadowAng.NativeFieldInfoPtr_ang2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowAng>.NativeClassPtr, "ang2");
			ShadowAng.NativeFieldInfoPtr_pt1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowAng>.NativeClassPtr, "pt1");
			ShadowAng.NativeFieldInfoPtr_pt2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowAng>.NativeClassPtr, "pt2");
			ShadowAng.NativeFieldInfoPtr_obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowAng>.NativeClassPtr, "obj");
			ShadowAng.NativeFieldInfoPtr_mRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowAng>.NativeClassPtr, "mRenderer");
			ShadowAng.NativeFieldInfoPtr_sRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowAng>.NativeClassPtr, "sRenderer");
			ShadowAng.NativeFieldInfoPtr_mMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowAng>.NativeClassPtr, "mMat");
			ShadowAng.NativeFieldInfoPtr_sMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowAng>.NativeClassPtr, "sMat");
			ShadowAng.NativeFieldInfoPtr_palMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowAng>.NativeClassPtr, "palMat");
			ShadowAng.NativeFieldInfoPtr_valid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowAng>.NativeClassPtr, "valid");
			ShadowAng.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowAng>.NativeClassPtr, "index");
			ShadowAng.NativeFieldInfoPtr_palIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowAng>.NativeClassPtr, "palIndex");
			ShadowAng.NativeFieldInfoPtr_tempMark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowAng>.NativeClassPtr, "tempMark");
			ShadowAng.NativeFieldInfoPtr_doneMark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowAng>.NativeClassPtr, "doneMark");
			ShadowAng.NativeFieldInfoPtr_matsAreSame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowAng>.NativeClassPtr, "matsAreSame");
			ShadowAng.NativeFieldInfoPtr_matIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowAng>.NativeClassPtr, "matIndex");
			ShadowAng.NativeFieldInfoPtr_pts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowAng>.NativeClassPtr, "pts");
			ShadowAng.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowAng>.NativeClassPtr, 100666895);
			ShadowAng.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_Single_Single_GameObject_Renderer_Renderer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowAng>.NativeClassPtr, 100666896);
			ShadowAng.NativeMethodInfoPtr_Set_Public_Void_Vector2_Vector2_Single_Single_GameObject_Renderer_Renderer_Int32_Int32_Int32_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowAng>.NativeClassPtr, 100666897);
			ShadowAng.NativeMethodInfoPtr_Overlaps_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowAng>.NativeClassPtr, 100666898);
		}

		// Token: 0x06002E08 RID: 11784 RVA: 0x000B35EC File Offset: 0x000B17EC
		[CallerCount(0)]
		public unsafe ShadowAng()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShadowAng>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowAng.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E09 RID: 11785 RVA: 0x000B3628 File Offset: 0x000B1828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81594, XrefRangeEnd = 81627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShadowAng(Vector2 p1, Vector2 p2, float a1, float a2, GameObject ob, Renderer rend, Renderer rend2, int num, int pName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShadowAng>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ob);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rend);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rend2);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref num;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pName;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowAng.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_Single_Single_GameObject_Renderer_Renderer_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E0A RID: 11786 RVA: 0x000B36F0 File Offset: 0x000B18F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81660, RefRangeEnd = 81661, XrefRangeStart = 81627, XrefRangeEnd = 81660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(Vector2 p1, Vector2 p2, float a1, float a2, GameObject ob, Renderer rend, Renderer rend2, int num, int pName, int matInd, Il2CppStructArray<Vector2> _pts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ob);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rend);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rend2);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref num;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pName;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matInd;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_pts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowAng.NativeMethodInfoPtr_Set_Public_Void_Vector2_Vector2_Single_Single_GameObject_Renderer_Renderer_Int32_Int32_Int32_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E0B RID: 11787 RVA: 0x000B37D4 File Offset: 0x000B19D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81661, XrefRangeEnd = 81665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Overlaps(float shadang1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shadang1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowAng.NativeMethodInfoPtr_Overlaps_Public_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E0C RID: 11788 RVA: 0x0001FCBE File Offset: 0x0001DEBE
		public ShadowAng(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001082 RID: 4226
		// (get) Token: 0x06002E0D RID: 11789 RVA: 0x000B3820 File Offset: 0x000B1A20
		// (set) Token: 0x06002E0E RID: 11790 RVA: 0x0001FCC7 File Offset: 0x0001DEC7
		public unsafe float ang1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_ang1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_ang1)) = value;
			}
		}

		// Token: 0x17001083 RID: 4227
		// (get) Token: 0x06002E0F RID: 11791 RVA: 0x000B3848 File Offset: 0x000B1A48
		// (set) Token: 0x06002E10 RID: 11792 RVA: 0x0001FCE2 File Offset: 0x0001DEE2
		public unsafe float ang2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_ang2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_ang2)) = value;
			}
		}

		// Token: 0x17001084 RID: 4228
		// (get) Token: 0x06002E11 RID: 11793 RVA: 0x000B3870 File Offset: 0x000B1A70
		// (set) Token: 0x06002E12 RID: 11794 RVA: 0x0001FCFD File Offset: 0x0001DEFD
		public unsafe Vector2 pt1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_pt1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_pt1)) = value;
			}
		}

		// Token: 0x17001085 RID: 4229
		// (get) Token: 0x06002E13 RID: 11795 RVA: 0x000B3898 File Offset: 0x000B1A98
		// (set) Token: 0x06002E14 RID: 11796 RVA: 0x0001FD18 File Offset: 0x0001DF18
		public unsafe Vector2 pt2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_pt2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_pt2)) = value;
			}
		}

		// Token: 0x17001086 RID: 4230
		// (get) Token: 0x06002E15 RID: 11797 RVA: 0x000B38C0 File Offset: 0x000B1AC0
		// (set) Token: 0x06002E16 RID: 11798 RVA: 0x0001FD33 File Offset: 0x0001DF33
		public unsafe GameObject obj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_obj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_obj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001087 RID: 4231
		// (get) Token: 0x06002E17 RID: 11799 RVA: 0x000B38F0 File Offset: 0x000B1AF0
		// (set) Token: 0x06002E18 RID: 11800 RVA: 0x0001FD52 File Offset: 0x0001DF52
		public unsafe Renderer mRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_mRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_mRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001088 RID: 4232
		// (get) Token: 0x06002E19 RID: 11801 RVA: 0x000B3920 File Offset: 0x000B1B20
		// (set) Token: 0x06002E1A RID: 11802 RVA: 0x0001FD71 File Offset: 0x0001DF71
		public unsafe Renderer sRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_sRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_sRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001089 RID: 4233
		// (get) Token: 0x06002E1B RID: 11803 RVA: 0x000B3950 File Offset: 0x000B1B50
		// (set) Token: 0x06002E1C RID: 11804 RVA: 0x0001FD90 File Offset: 0x0001DF90
		public unsafe Material mMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_mMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_mMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700108A RID: 4234
		// (get) Token: 0x06002E1D RID: 11805 RVA: 0x000B3980 File Offset: 0x000B1B80
		// (set) Token: 0x06002E1E RID: 11806 RVA: 0x0001FDAF File Offset: 0x0001DFAF
		public unsafe Material sMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_sMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_sMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700108B RID: 4235
		// (get) Token: 0x06002E1F RID: 11807 RVA: 0x000B39B0 File Offset: 0x000B1BB0
		// (set) Token: 0x06002E20 RID: 11808 RVA: 0x0001FDCE File Offset: 0x0001DFCE
		public unsafe Material palMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_palMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_palMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700108C RID: 4236
		// (get) Token: 0x06002E21 RID: 11809 RVA: 0x000B39E0 File Offset: 0x000B1BE0
		// (set) Token: 0x06002E22 RID: 11810 RVA: 0x0001FDED File Offset: 0x0001DFED
		public unsafe bool valid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_valid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_valid)) = value;
			}
		}

		// Token: 0x1700108D RID: 4237
		// (get) Token: 0x06002E23 RID: 11811 RVA: 0x000B3A08 File Offset: 0x000B1C08
		// (set) Token: 0x06002E24 RID: 11812 RVA: 0x0001FE08 File Offset: 0x0001E008
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x1700108E RID: 4238
		// (get) Token: 0x06002E25 RID: 11813 RVA: 0x000B3A30 File Offset: 0x000B1C30
		// (set) Token: 0x06002E26 RID: 11814 RVA: 0x0001FE23 File Offset: 0x0001E023
		public unsafe int palIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_palIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_palIndex)) = value;
			}
		}

		// Token: 0x1700108F RID: 4239
		// (get) Token: 0x06002E27 RID: 11815 RVA: 0x000B3A58 File Offset: 0x000B1C58
		// (set) Token: 0x06002E28 RID: 11816 RVA: 0x0001FE3E File Offset: 0x0001E03E
		public unsafe bool tempMark
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_tempMark);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_tempMark)) = value;
			}
		}

		// Token: 0x17001090 RID: 4240
		// (get) Token: 0x06002E29 RID: 11817 RVA: 0x000B3A80 File Offset: 0x000B1C80
		// (set) Token: 0x06002E2A RID: 11818 RVA: 0x0001FE59 File Offset: 0x0001E059
		public unsafe bool doneMark
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_doneMark);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_doneMark)) = value;
			}
		}

		// Token: 0x17001091 RID: 4241
		// (get) Token: 0x06002E2B RID: 11819 RVA: 0x000B3AA8 File Offset: 0x000B1CA8
		// (set) Token: 0x06002E2C RID: 11820 RVA: 0x0001FE74 File Offset: 0x0001E074
		public unsafe bool matsAreSame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_matsAreSame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_matsAreSame)) = value;
			}
		}

		// Token: 0x17001092 RID: 4242
		// (get) Token: 0x06002E2D RID: 11821 RVA: 0x000B3AD0 File Offset: 0x000B1CD0
		// (set) Token: 0x06002E2E RID: 11822 RVA: 0x0001FE8F File Offset: 0x0001E08F
		public unsafe int matIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_matIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_matIndex)) = value;
			}
		}

		// Token: 0x17001093 RID: 4243
		// (get) Token: 0x06002E2F RID: 11823 RVA: 0x000B3AF8 File Offset: 0x000B1CF8
		// (set) Token: 0x06002E30 RID: 11824 RVA: 0x0001FEAA File Offset: 0x0001E0AA
		public unsafe Il2CppStructArray<Vector2> pts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_pts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowAng.NativeFieldInfoPtr_pts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B18 RID: 6936
		private static readonly IntPtr NativeFieldInfoPtr_ang1;

		// Token: 0x04001B19 RID: 6937
		private static readonly IntPtr NativeFieldInfoPtr_ang2;

		// Token: 0x04001B1A RID: 6938
		private static readonly IntPtr NativeFieldInfoPtr_pt1;

		// Token: 0x04001B1B RID: 6939
		private static readonly IntPtr NativeFieldInfoPtr_pt2;

		// Token: 0x04001B1C RID: 6940
		private static readonly IntPtr NativeFieldInfoPtr_obj;

		// Token: 0x04001B1D RID: 6941
		private static readonly IntPtr NativeFieldInfoPtr_mRenderer;

		// Token: 0x04001B1E RID: 6942
		private static readonly IntPtr NativeFieldInfoPtr_sRenderer;

		// Token: 0x04001B1F RID: 6943
		private static readonly IntPtr NativeFieldInfoPtr_mMat;

		// Token: 0x04001B20 RID: 6944
		private static readonly IntPtr NativeFieldInfoPtr_sMat;

		// Token: 0x04001B21 RID: 6945
		private static readonly IntPtr NativeFieldInfoPtr_palMat;

		// Token: 0x04001B22 RID: 6946
		private static readonly IntPtr NativeFieldInfoPtr_valid;

		// Token: 0x04001B23 RID: 6947
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04001B24 RID: 6948
		private static readonly IntPtr NativeFieldInfoPtr_palIndex;

		// Token: 0x04001B25 RID: 6949
		private static readonly IntPtr NativeFieldInfoPtr_tempMark;

		// Token: 0x04001B26 RID: 6950
		private static readonly IntPtr NativeFieldInfoPtr_doneMark;

		// Token: 0x04001B27 RID: 6951
		private static readonly IntPtr NativeFieldInfoPtr_matsAreSame;

		// Token: 0x04001B28 RID: 6952
		private static readonly IntPtr NativeFieldInfoPtr_matIndex;

		// Token: 0x04001B29 RID: 6953
		private static readonly IntPtr NativeFieldInfoPtr_pts;

		// Token: 0x04001B2A RID: 6954
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001B2B RID: 6955
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_Single_Single_GameObject_Renderer_Renderer_Int32_Int32_0;

		// Token: 0x04001B2C RID: 6956
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_Vector2_Vector2_Single_Single_GameObject_Renderer_Renderer_Int32_Int32_Int32_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04001B2D RID: 6957
		private static readonly IntPtr NativeMethodInfoPtr_Overlaps_Public_Boolean_Single_0;
	}
}
