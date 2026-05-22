using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UI
{
	// Token: 0x0200001C RID: 28
	public class GridLayoutGroup : LayoutGroup
	{
		// Token: 0x060003F0 RID: 1008 RVA: 0x00015CF8 File Offset: 0x00013EF8
		// Note: this type is marked as 'beforefieldinit'.
		static GridLayoutGroup()
		{
			Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "GridLayoutGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr);
			GridLayoutGroup.NativeFieldInfoPtr_m_StartCorner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, "m_StartCorner");
			GridLayoutGroup.NativeFieldInfoPtr_m_StartAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, "m_StartAxis");
			GridLayoutGroup.NativeFieldInfoPtr_m_CellSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, "m_CellSize");
			GridLayoutGroup.NativeFieldInfoPtr_m_Spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, "m_Spacing");
			GridLayoutGroup.NativeFieldInfoPtr_m_Constraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, "m_Constraint");
			GridLayoutGroup.NativeFieldInfoPtr_m_ConstraintCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, "m_ConstraintCount");
			GridLayoutGroup.NativeMethodInfoPtr_get_startCorner_Public_get_Corner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663930);
			GridLayoutGroup.NativeMethodInfoPtr_set_startCorner_Public_set_Void_Corner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663931);
			GridLayoutGroup.NativeMethodInfoPtr_get_startAxis_Public_get_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663932);
			GridLayoutGroup.NativeMethodInfoPtr_set_startAxis_Public_set_Void_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663933);
			GridLayoutGroup.NativeMethodInfoPtr_get_cellSize_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663934);
			GridLayoutGroup.NativeMethodInfoPtr_set_cellSize_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663935);
			GridLayoutGroup.NativeMethodInfoPtr_get_spacing_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663936);
			GridLayoutGroup.NativeMethodInfoPtr_set_spacing_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663937);
			GridLayoutGroup.NativeMethodInfoPtr_get_constraint_Public_get_Constraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663938);
			GridLayoutGroup.NativeMethodInfoPtr_set_constraint_Public_set_Void_Constraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663939);
			GridLayoutGroup.NativeMethodInfoPtr_get_constraintCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663940);
			GridLayoutGroup.NativeMethodInfoPtr_set_constraintCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663941);
			GridLayoutGroup.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663942);
			GridLayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663943);
			GridLayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663944);
			GridLayoutGroup.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663945);
			GridLayoutGroup.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663946);
			GridLayoutGroup.NativeMethodInfoPtr_SetCellsAlongAxis_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663947);
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x00015F08 File Offset: 0x00014108
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x00015F44 File Offset: 0x00014144
		public unsafe GridLayoutGroup.Corner startCorner
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_get_startCorner_Public_get_Corner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523591, XrefRangeEnd = 523594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_set_startCorner_Public_set_Void_Corner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x00015F84 File Offset: 0x00014184
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x00015FC0 File Offset: 0x000141C0
		public unsafe GridLayoutGroup.Axis startAxis
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_get_startAxis_Public_get_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523594, XrefRangeEnd = 523597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_set_startAxis_Public_set_Void_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x00016000 File Offset: 0x00014200
		// (set) Token: 0x060003F6 RID: 1014 RVA: 0x0001603C File Offset: 0x0001423C
		public unsafe Vector2 cellSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_get_cellSize_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523597, XrefRangeEnd = 523599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_set_cellSize_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x0001607C File Offset: 0x0001427C
		// (set) Token: 0x060003F8 RID: 1016 RVA: 0x000160B8 File Offset: 0x000142B8
		public unsafe Vector2 spacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_get_spacing_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523599, XrefRangeEnd = 523601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_set_spacing_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x000160F8 File Offset: 0x000142F8
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x00016134 File Offset: 0x00014334
		public unsafe GridLayoutGroup.Constraint constraint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_get_constraint_Public_get_Constraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523601, XrefRangeEnd = 523604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_set_constraint_Public_set_Void_Constraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x00016174 File Offset: 0x00014374
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x000161B0 File Offset: 0x000143B0
		public unsafe int constraintCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_get_constraintCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523604, XrefRangeEnd = 523611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_set_constraintCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x000161F0 File Offset: 0x000143F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523611, XrefRangeEnd = 523614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GridLayoutGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0001622C File Offset: 0x0001442C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523614, XrefRangeEnd = 523627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalculateLayoutInputHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridLayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00016268 File Offset: 0x00014468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523627, XrefRangeEnd = 523639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalculateLayoutInputVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridLayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x000162A4 File Offset: 0x000144A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523639, XrefRangeEnd = 523640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetLayoutHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridLayoutGroup.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x000162E0 File Offset: 0x000144E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523640, XrefRangeEnd = 523641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetLayoutVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridLayoutGroup.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0001631C File Offset: 0x0001451C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 523667, RefRangeEnd = 523669, XrefRangeStart = 523641, XrefRangeEnd = 523667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCellsAlongAxis(int axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_SetCellsAlongAxis_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x000035FD File Offset: 0x000017FD
		public GridLayoutGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x0001635C File Offset: 0x0001455C
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x00003606 File Offset: 0x00001806
		public unsafe GridLayoutGroup.Corner m_StartCorner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_StartCorner);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_StartCorner)) = value;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x00016384 File Offset: 0x00014584
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x00003621 File Offset: 0x00001821
		public unsafe GridLayoutGroup.Axis m_StartAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_StartAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_StartAxis)) = value;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x000163AC File Offset: 0x000145AC
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x0000363C File Offset: 0x0000183C
		public unsafe Vector2 m_CellSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_CellSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_CellSize)) = value;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x000163D4 File Offset: 0x000145D4
		// (set) Token: 0x0600040B RID: 1035 RVA: 0x00003657 File Offset: 0x00001857
		public unsafe Vector2 m_Spacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_Spacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_Spacing)) = value;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x000163FC File Offset: 0x000145FC
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x00003672 File Offset: 0x00001872
		public unsafe GridLayoutGroup.Constraint m_Constraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_Constraint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_Constraint)) = value;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x00016424 File Offset: 0x00014624
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x0000368D File Offset: 0x0000188D
		public unsafe int m_ConstraintCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_ConstraintCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_ConstraintCount)) = value;
			}
		}

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeFieldInfoPtr_m_StartCorner;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeFieldInfoPtr_m_StartAxis;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeFieldInfoPtr_m_CellSize;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeFieldInfoPtr_m_Spacing;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeFieldInfoPtr_m_Constraint;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeFieldInfoPtr_m_ConstraintCount;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeMethodInfoPtr_get_startCorner_Public_get_Corner_0;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeMethodInfoPtr_set_startCorner_Public_set_Void_Corner_0;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeMethodInfoPtr_get_startAxis_Public_get_Axis_0;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeMethodInfoPtr_set_startAxis_Public_set_Void_Axis_0;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeMethodInfoPtr_get_cellSize_Public_get_Vector2_0;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeMethodInfoPtr_set_cellSize_Public_set_Void_Vector2_0;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeMethodInfoPtr_get_spacing_Public_get_Vector2_0;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeMethodInfoPtr_set_spacing_Public_set_Void_Vector2_0;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeMethodInfoPtr_get_constraint_Public_get_Constraint_0;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeMethodInfoPtr_set_constraint_Public_set_Void_Constraint_0;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeMethodInfoPtr_get_constraintCount_Public_get_Int32_0;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeMethodInfoPtr_set_constraintCount_Public_set_Void_Int32_0;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0;

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeMethodInfoPtr_SetCellsAlongAxis_Private_Void_Int32_0;

		// Token: 0x02000098 RID: 152
		[OriginalName("UnityEngine.UI.dll", "", "Corner")]
		public enum Corner
		{
			// Token: 0x04000926 RID: 2342
			UpperLeft,
			// Token: 0x04000927 RID: 2343
			UpperRight,
			// Token: 0x04000928 RID: 2344
			LowerLeft,
			// Token: 0x04000929 RID: 2345
			LowerRight
		}

		// Token: 0x02000099 RID: 153
		[OriginalName("UnityEngine.UI.dll", "", "Axis")]
		public enum Axis
		{
			// Token: 0x0400092B RID: 2347
			Horizontal,
			// Token: 0x0400092C RID: 2348
			Vertical
		}

		// Token: 0x0200009A RID: 154
		[OriginalName("UnityEngine.UI.dll", "", "Constraint")]
		public enum Constraint
		{
			// Token: 0x0400092E RID: 2350
			Flexible,
			// Token: 0x0400092F RID: 2351
			FixedColumnCount,
			// Token: 0x04000930 RID: 2352
			FixedRowCount
		}
	}
}
