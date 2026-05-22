using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine.UI
{
	// Token: 0x02000038 RID: 56
	public static class StencilMaterial : Object
	{
		// Token: 0x0600074B RID: 1867 RVA: 0x00023104 File Offset: 0x00021304
		// Note: this type is marked as 'beforefieldinit'.
		static StencilMaterial()
		{
			Il2CppClassPointerStore<StencilMaterial>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "StencilMaterial");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StencilMaterial>.NativeClassPtr);
			StencilMaterial.NativeFieldInfoPtr_m_List = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilMaterial>.NativeClassPtr, "m_List");
			StencilMaterial.NativeMethodInfoPtr_Add_Public_Static_Material_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilMaterial>.NativeClassPtr, 100664461);
			StencilMaterial.NativeMethodInfoPtr_Add_Public_Static_Material_Material_Int32_StencilOp_CompareFunction_ColorWriteMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilMaterial>.NativeClassPtr, 100664462);
			StencilMaterial.NativeMethodInfoPtr_LogWarningWhenNotInBatchmode_Private_Static_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilMaterial>.NativeClassPtr, 100664463);
			StencilMaterial.NativeMethodInfoPtr_Add_Public_Static_Material_Material_Int32_StencilOp_CompareFunction_ColorWriteMask_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilMaterial>.NativeClassPtr, 100664464);
			StencilMaterial.NativeMethodInfoPtr_Remove_Public_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilMaterial>.NativeClassPtr, 100664465);
			StencilMaterial.NativeMethodInfoPtr_ClearAll_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilMaterial>.NativeClassPtr, 100664466);
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x000231C0 File Offset: 0x000213C0
		[CallerCount(0)]
		public unsafe static Material Add(Material baseMat, int stencilID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseMat);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilMaterial.NativeMethodInfoPtr_Add_Public_Static_Material_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00023214 File Offset: 0x00021414
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 528428, RefRangeEnd = 528430, XrefRangeStart = 528424, XrefRangeEnd = 528428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseMat);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref operation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compareFunction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorWriteMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilMaterial.NativeMethodInfoPtr_Add_Public_Static_Material_Material_Int32_StencilOp_CompareFunction_ColorWriteMask_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00023290 File Offset: 0x00021490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528430, XrefRangeEnd = 528436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogWarningWhenNotInBatchmode(string warning, Object context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(warning);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilMaterial.NativeMethodInfoPtr_LogWarningWhenNotInBatchmode_Private_Static_Void_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x000232D8 File Offset: 0x000214D8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 528517, RefRangeEnd = 528523, XrefRangeStart = 528436, XrefRangeEnd = 528517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseMat);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref operation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compareFunction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorWriteMask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readMask;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilMaterial.NativeMethodInfoPtr_Add_Public_Static_Material_Material_Int32_StencilOp_CompareFunction_ColorWriteMask_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00023370 File Offset: 0x00021570
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 528562, RefRangeEnd = 528572, XrefRangeStart = 528523, XrefRangeEnd = 528562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Remove(Material customMat)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(customMat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilMaterial.NativeMethodInfoPtr_Remove_Public_Static_Void_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x000233A8 File Offset: 0x000215A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528572, XrefRangeEnd = 528587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilMaterial.NativeMethodInfoPtr_ClearAll_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x000048AF File Offset: 0x00002AAF
		public StencilMaterial(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x000233D0 File Offset: 0x000215D0
		// (set) Token: 0x06000754 RID: 1876 RVA: 0x000048B8 File Offset: 0x00002AB8
		public unsafe static List<StencilMaterial.MatEntry> m_List
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StencilMaterial.NativeFieldInfoPtr_m_List, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StencilMaterial.MatEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StencilMaterial.NativeFieldInfoPtr_m_List, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeFieldInfoPtr_m_List;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Static_Material_Material_Int32_0;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Static_Material_Material_Int32_StencilOp_CompareFunction_ColorWriteMask_0;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeMethodInfoPtr_LogWarningWhenNotInBatchmode_Private_Static_Void_String_Object_0;

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Static_Material_Material_Int32_StencilOp_CompareFunction_ColorWriteMask_Int32_Int32_0;

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Static_Void_Material_0;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeMethodInfoPtr_ClearAll_Public_Static_Void_0;

		// Token: 0x020000AF RID: 175
		public class MatEntry : Object
		{
			// Token: 0x06000C33 RID: 3123 RVA: 0x00034D98 File Offset: 0x00032F98
			// Note: this type is marked as 'beforefieldinit'.
			static MatEntry()
			{
				Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StencilMaterial>.NativeClassPtr, "MatEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr);
				StencilMaterial.MatEntry.NativeFieldInfoPtr_baseMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr, "baseMat");
				StencilMaterial.MatEntry.NativeFieldInfoPtr_customMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr, "customMat");
				StencilMaterial.MatEntry.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr, "count");
				StencilMaterial.MatEntry.NativeFieldInfoPtr_stencilId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr, "stencilId");
				StencilMaterial.MatEntry.NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr, "operation");
				StencilMaterial.MatEntry.NativeFieldInfoPtr_compareFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr, "compareFunction");
				StencilMaterial.MatEntry.NativeFieldInfoPtr_readMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr, "readMask");
				StencilMaterial.MatEntry.NativeFieldInfoPtr_writeMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr, "writeMask");
				StencilMaterial.MatEntry.NativeFieldInfoPtr_useAlphaClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr, "useAlphaClip");
				StencilMaterial.MatEntry.NativeFieldInfoPtr_colorMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr, "colorMask");
				StencilMaterial.MatEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr, 100664468);
			}

			// Token: 0x06000C34 RID: 3124 RVA: 0x00034EA0 File Offset: 0x000330A0
			[CallerCount(0)]
			public unsafe MatEntry()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilMaterial.MatEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C35 RID: 3125 RVA: 0x0000693D File Offset: 0x00004B3D
			public MatEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700040D RID: 1037
			// (get) Token: 0x06000C36 RID: 3126 RVA: 0x00034EDC File Offset: 0x000330DC
			// (set) Token: 0x06000C37 RID: 3127 RVA: 0x00006946 File Offset: 0x00004B46
			public unsafe Material baseMat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_baseMat);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_baseMat), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700040E RID: 1038
			// (get) Token: 0x06000C38 RID: 3128 RVA: 0x00034F0C File Offset: 0x0003310C
			// (set) Token: 0x06000C39 RID: 3129 RVA: 0x00006965 File Offset: 0x00004B65
			public unsafe Material customMat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_customMat);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_customMat), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700040F RID: 1039
			// (get) Token: 0x06000C3A RID: 3130 RVA: 0x00034F3C File Offset: 0x0003313C
			// (set) Token: 0x06000C3B RID: 3131 RVA: 0x00006984 File Offset: 0x00004B84
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x17000410 RID: 1040
			// (get) Token: 0x06000C3C RID: 3132 RVA: 0x00034F64 File Offset: 0x00033164
			// (set) Token: 0x06000C3D RID: 3133 RVA: 0x0000699F File Offset: 0x00004B9F
			public unsafe int stencilId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_stencilId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_stencilId)) = value;
				}
			}

			// Token: 0x17000411 RID: 1041
			// (get) Token: 0x06000C3E RID: 3134 RVA: 0x00034F8C File Offset: 0x0003318C
			// (set) Token: 0x06000C3F RID: 3135 RVA: 0x000069BA File Offset: 0x00004BBA
			public unsafe StencilOp operation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_operation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_operation)) = value;
				}
			}

			// Token: 0x17000412 RID: 1042
			// (get) Token: 0x06000C40 RID: 3136 RVA: 0x00034FB4 File Offset: 0x000331B4
			// (set) Token: 0x06000C41 RID: 3137 RVA: 0x000069D5 File Offset: 0x00004BD5
			public unsafe CompareFunction compareFunction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_compareFunction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_compareFunction)) = value;
				}
			}

			// Token: 0x17000413 RID: 1043
			// (get) Token: 0x06000C42 RID: 3138 RVA: 0x00034FDC File Offset: 0x000331DC
			// (set) Token: 0x06000C43 RID: 3139 RVA: 0x000069F0 File Offset: 0x00004BF0
			public unsafe int readMask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_readMask);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_readMask)) = value;
				}
			}

			// Token: 0x17000414 RID: 1044
			// (get) Token: 0x06000C44 RID: 3140 RVA: 0x00035004 File Offset: 0x00033204
			// (set) Token: 0x06000C45 RID: 3141 RVA: 0x00006A0B File Offset: 0x00004C0B
			public unsafe int writeMask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_writeMask);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_writeMask)) = value;
				}
			}

			// Token: 0x17000415 RID: 1045
			// (get) Token: 0x06000C46 RID: 3142 RVA: 0x0003502C File Offset: 0x0003322C
			// (set) Token: 0x06000C47 RID: 3143 RVA: 0x00006A26 File Offset: 0x00004C26
			public unsafe bool useAlphaClip
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_useAlphaClip);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_useAlphaClip)) = value;
				}
			}

			// Token: 0x17000416 RID: 1046
			// (get) Token: 0x06000C48 RID: 3144 RVA: 0x00035054 File Offset: 0x00033254
			// (set) Token: 0x06000C49 RID: 3145 RVA: 0x00006A41 File Offset: 0x00004C41
			public unsafe ColorWriteMask colorMask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_colorMask);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_colorMask)) = value;
				}
			}

			// Token: 0x04000994 RID: 2452
			private static readonly IntPtr NativeFieldInfoPtr_baseMat;

			// Token: 0x04000995 RID: 2453
			private static readonly IntPtr NativeFieldInfoPtr_customMat;

			// Token: 0x04000996 RID: 2454
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x04000997 RID: 2455
			private static readonly IntPtr NativeFieldInfoPtr_stencilId;

			// Token: 0x04000998 RID: 2456
			private static readonly IntPtr NativeFieldInfoPtr_operation;

			// Token: 0x04000999 RID: 2457
			private static readonly IntPtr NativeFieldInfoPtr_compareFunction;

			// Token: 0x0400099A RID: 2458
			private static readonly IntPtr NativeFieldInfoPtr_readMask;

			// Token: 0x0400099B RID: 2459
			private static readonly IntPtr NativeFieldInfoPtr_writeMask;

			// Token: 0x0400099C RID: 2460
			private static readonly IntPtr NativeFieldInfoPtr_useAlphaClip;

			// Token: 0x0400099D RID: 2461
			private static readonly IntPtr NativeFieldInfoPtr_colorMask;

			// Token: 0x0400099E RID: 2462
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
