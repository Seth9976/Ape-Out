using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000F8 RID: 248
	public class ForwardAxis : Object
	{
		// Token: 0x060014A8 RID: 5288 RVA: 0x0006BA98 File Offset: 0x00069C98
		// Note: this type is marked as 'beforefieldinit'.
		static ForwardAxis()
		{
			Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "ForwardAxis");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr);
			ForwardAxis.NativeFieldInfoPtr_topNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr, "topNode");
			ForwardAxis.NativeFieldInfoPtr_rootNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr, "rootNode");
			ForwardAxis.NativeFieldInfoPtr_isAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr, "isAttribute");
			ForwardAxis.NativeFieldInfoPtr_isDss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr, "isDss");
			ForwardAxis.NativeFieldInfoPtr_isSelfAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr, "isSelfAxis");
			ForwardAxis.NativeMethodInfoPtr_get_RootNode_Internal_get_DoubleLinkAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr, 100666459);
			ForwardAxis.NativeMethodInfoPtr_get_TopNode_Internal_get_DoubleLinkAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr, 100666460);
			ForwardAxis.NativeMethodInfoPtr_get_IsAttribute_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr, 100666461);
			ForwardAxis.NativeMethodInfoPtr_get_IsDss_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr, 100666462);
			ForwardAxis.NativeMethodInfoPtr_get_IsSelfAxis_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr, 100666463);
			ForwardAxis.NativeMethodInfoPtr__ctor_Public_Void_DoubleLinkAxis_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr, 100666464);
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x060014A9 RID: 5289 RVA: 0x0006BBA4 File Offset: 0x00069DA4
		public unsafe DoubleLinkAxis RootNode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardAxis.NativeMethodInfoPtr_get_RootNode_Internal_get_DoubleLinkAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DoubleLinkAxis>(intPtr3) : null;
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x060014AA RID: 5290 RVA: 0x0006BBE4 File Offset: 0x00069DE4
		public unsafe DoubleLinkAxis TopNode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardAxis.NativeMethodInfoPtr_get_TopNode_Internal_get_DoubleLinkAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DoubleLinkAxis>(intPtr3) : null;
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x060014AB RID: 5291 RVA: 0x0006BC24 File Offset: 0x00069E24
		public unsafe bool IsAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardAxis.NativeMethodInfoPtr_get_IsAttribute_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x060014AC RID: 5292 RVA: 0x0006BC60 File Offset: 0x00069E60
		public unsafe bool IsDss
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardAxis.NativeMethodInfoPtr_get_IsDss_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x060014AD RID: 5293 RVA: 0x0006BC9C File Offset: 0x00069E9C
		public unsafe bool IsSelfAxis
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardAxis.NativeMethodInfoPtr_get_IsSelfAxis_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x0006BCD8 File Offset: 0x00069ED8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 407976, RefRangeEnd = 407979, XrefRangeStart = 407972, XrefRangeEnd = 407976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ForwardAxis(DoubleLinkAxis axis, bool isdesorself)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isdesorself;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardAxis.NativeMethodInfoPtr__ctor_Public_Void_DoubleLinkAxis_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x0000939F File Offset: 0x0000759F
		public ForwardAxis(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x060014B0 RID: 5296 RVA: 0x0006BD34 File Offset: 0x00069F34
		// (set) Token: 0x060014B1 RID: 5297 RVA: 0x000093A8 File Offset: 0x000075A8
		public unsafe DoubleLinkAxis topNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardAxis.NativeFieldInfoPtr_topNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DoubleLinkAxis>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardAxis.NativeFieldInfoPtr_topNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x060014B2 RID: 5298 RVA: 0x0006BD64 File Offset: 0x00069F64
		// (set) Token: 0x060014B3 RID: 5299 RVA: 0x000093C7 File Offset: 0x000075C7
		public unsafe DoubleLinkAxis rootNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardAxis.NativeFieldInfoPtr_rootNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DoubleLinkAxis>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardAxis.NativeFieldInfoPtr_rootNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x060014B4 RID: 5300 RVA: 0x0006BD94 File Offset: 0x00069F94
		// (set) Token: 0x060014B5 RID: 5301 RVA: 0x000093E6 File Offset: 0x000075E6
		public unsafe bool isAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardAxis.NativeFieldInfoPtr_isAttribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardAxis.NativeFieldInfoPtr_isAttribute)) = value;
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x060014B6 RID: 5302 RVA: 0x0006BDBC File Offset: 0x00069FBC
		// (set) Token: 0x060014B7 RID: 5303 RVA: 0x00009401 File Offset: 0x00007601
		public unsafe bool isDss
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardAxis.NativeFieldInfoPtr_isDss);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardAxis.NativeFieldInfoPtr_isDss)) = value;
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x060014B8 RID: 5304 RVA: 0x0006BDE4 File Offset: 0x00069FE4
		// (set) Token: 0x060014B9 RID: 5305 RVA: 0x0000941C File Offset: 0x0000761C
		public unsafe bool isSelfAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardAxis.NativeFieldInfoPtr_isSelfAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardAxis.NativeFieldInfoPtr_isSelfAxis)) = value;
			}
		}

		// Token: 0x04000FE1 RID: 4065
		private static readonly IntPtr NativeFieldInfoPtr_topNode;

		// Token: 0x04000FE2 RID: 4066
		private static readonly IntPtr NativeFieldInfoPtr_rootNode;

		// Token: 0x04000FE3 RID: 4067
		private static readonly IntPtr NativeFieldInfoPtr_isAttribute;

		// Token: 0x04000FE4 RID: 4068
		private static readonly IntPtr NativeFieldInfoPtr_isDss;

		// Token: 0x04000FE5 RID: 4069
		private static readonly IntPtr NativeFieldInfoPtr_isSelfAxis;

		// Token: 0x04000FE6 RID: 4070
		private static readonly IntPtr NativeMethodInfoPtr_get_RootNode_Internal_get_DoubleLinkAxis_0;

		// Token: 0x04000FE7 RID: 4071
		private static readonly IntPtr NativeMethodInfoPtr_get_TopNode_Internal_get_DoubleLinkAxis_0;

		// Token: 0x04000FE8 RID: 4072
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAttribute_Internal_get_Boolean_0;

		// Token: 0x04000FE9 RID: 4073
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDss_Internal_get_Boolean_0;

		// Token: 0x04000FEA RID: 4074
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSelfAxis_Internal_get_Boolean_0;

		// Token: 0x04000FEB RID: 4075
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DoubleLinkAxis_Boolean_0;
	}
}
