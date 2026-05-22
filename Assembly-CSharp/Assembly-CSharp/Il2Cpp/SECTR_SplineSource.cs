using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000046 RID: 70
	public class SECTR_SplineSource : SECTR_PointSource
	{
		// Token: 0x06000AAB RID: 2731 RVA: 0x00053B40 File Offset: 0x00051D40
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_SplineSource()
		{
			Il2CppClassPointerStore<SECTR_SplineSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_SplineSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_SplineSource>.NativeClassPtr);
			SECTR_SplineSource.NativeFieldInfoPtr_nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_SplineSource>.NativeClassPtr, "nodes");
			SECTR_SplineSource.NativeFieldInfoPtr_SplinePoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_SplineSource>.NativeClassPtr, "SplinePoints");
			SECTR_SplineSource.NativeFieldInfoPtr_Closed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_SplineSource>.NativeClassPtr, "Closed");
			SECTR_SplineSource.NativeFieldInfoPtr_MaxInterpSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_SplineSource>.NativeClassPtr, "MaxInterpSpeed");
			SECTR_SplineSource.NativeMethodInfoPtr_Play_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_SplineSource>.NativeClassPtr, 100664183);
			SECTR_SplineSource.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_SplineSource>.NativeClassPtr, 100664184);
			SECTR_SplineSource.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_SplineSource>.NativeClassPtr, 100664185);
			SECTR_SplineSource.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_SplineSource>.NativeClassPtr, 100664186);
			SECTR_SplineSource.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_SplineSource>.NativeClassPtr, 100664187);
			SECTR_SplineSource.NativeMethodInfoPtr__SetupSpline_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_SplineSource>.NativeClassPtr, 100664188);
			SECTR_SplineSource.NativeMethodInfoPtr__GetClosestPointOnSpline_Private_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_SplineSource>.NativeClassPtr, 100664189);
			SECTR_SplineSource.NativeMethodInfoPtr__GetHermiteAtT_Private_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_SplineSource>.NativeClassPtr, 100664190);
			SECTR_SplineSource.NativeMethodInfoPtr__Ease_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_SplineSource>.NativeClassPtr, 100664191);
			SECTR_SplineSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_SplineSource>.NativeClassPtr, 100664192);
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x00053C88 File Offset: 0x00051E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40377, XrefRangeEnd = 40394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_SplineSource.NativeMethodInfoPtr_Play_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x00053CC4 File Offset: 0x00051EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40394, XrefRangeEnd = 40395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_SplineSource.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x00053CF8 File Offset: 0x00051EF8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_SplineSource.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x00053D2C File Offset: 0x00051F2C
		[CallerCount(0)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_SplineSource.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x00053D68 File Offset: 0x00051F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40395, XrefRangeEnd = 40421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_SplineSource.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x00053D9C File Offset: 0x00051F9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40463, RefRangeEnd = 40464, XrefRangeStart = 40421, XrefRangeEnd = 40463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SetupSpline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_SplineSource.NativeMethodInfoPtr__SetupSpline_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x00053DD0 File Offset: 0x00051FD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40476, RefRangeEnd = 40478, XrefRangeStart = 40464, XrefRangeEnd = 40476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 _GetClosestPointOnSpline(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_SplineSource.NativeMethodInfoPtr__GetClosestPointOnSpline_Private_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x00053E1C File Offset: 0x0005201C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40486, RefRangeEnd = 40487, XrefRangeStart = 40478, XrefRangeEnd = 40486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 _GetHermiteAtT(float timeParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeParam;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_SplineSource.NativeMethodInfoPtr__GetHermiteAtT_Private_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00053E68 File Offset: 0x00052068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40487, XrefRangeEnd = 40491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _Ease(float t, float k1, float k2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref k1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref k2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_SplineSource.NativeMethodInfoPtr__Ease_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x00053ED0 File Offset: 0x000520D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40491, XrefRangeEnd = 40508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_SplineSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_SplineSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_SplineSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x00008B0B File Offset: 0x00006D0B
		public SECTR_SplineSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x00053F0C File Offset: 0x0005210C
		// (set) Token: 0x06000AB8 RID: 2744 RVA: 0x00008B14 File Offset: 0x00006D14
		public unsafe List<SECTR_SplineSource.SplineNode> nodes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_SplineSource.NativeFieldInfoPtr_nodes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SECTR_SplineSource.SplineNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_SplineSource.NativeFieldInfoPtr_nodes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x00053F3C File Offset: 0x0005213C
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x00008B33 File Offset: 0x00006D33
		public unsafe List<Transform> SplinePoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_SplineSource.NativeFieldInfoPtr_SplinePoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_SplineSource.NativeFieldInfoPtr_SplinePoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x00053F6C File Offset: 0x0005216C
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x00008B52 File Offset: 0x00006D52
		public unsafe bool Closed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_SplineSource.NativeFieldInfoPtr_Closed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_SplineSource.NativeFieldInfoPtr_Closed)) = value;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x00053F94 File Offset: 0x00052194
		// (set) Token: 0x06000ABE RID: 2750 RVA: 0x00008B6D File Offset: 0x00006D6D
		public unsafe float MaxInterpSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_SplineSource.NativeFieldInfoPtr_MaxInterpSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_SplineSource.NativeFieldInfoPtr_MaxInterpSpeed)) = value;
			}
		}

		// Token: 0x0400067A RID: 1658
		private static readonly IntPtr NativeFieldInfoPtr_nodes;

		// Token: 0x0400067B RID: 1659
		private static readonly IntPtr NativeFieldInfoPtr_SplinePoints;

		// Token: 0x0400067C RID: 1660
		private static readonly IntPtr NativeFieldInfoPtr_Closed;

		// Token: 0x0400067D RID: 1661
		private static readonly IntPtr NativeFieldInfoPtr_MaxInterpSpeed;

		// Token: 0x0400067E RID: 1662
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_Void_0;

		// Token: 0x0400067F RID: 1663
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000680 RID: 1664
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000681 RID: 1665
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x04000682 RID: 1666
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000683 RID: 1667
		private static readonly IntPtr NativeMethodInfoPtr__SetupSpline_Private_Void_0;

		// Token: 0x04000684 RID: 1668
		private static readonly IntPtr NativeMethodInfoPtr__GetClosestPointOnSpline_Private_Vector3_Vector3_0;

		// Token: 0x04000685 RID: 1669
		private static readonly IntPtr NativeMethodInfoPtr__GetHermiteAtT_Private_Vector3_Single_0;

		// Token: 0x04000686 RID: 1670
		private static readonly IntPtr NativeMethodInfoPtr__Ease_Private_Single_Single_Single_Single_0;

		// Token: 0x04000687 RID: 1671
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002BD RID: 701
		public class SplineNode : global::Il2CppSystem.Object
		{
			// Token: 0x06004BAD RID: 19373 RVA: 0x00117928 File Offset: 0x00115B28
			// Note: this type is marked as 'beforefieldinit'.
			static SplineNode()
			{
				Il2CppClassPointerStore<SECTR_SplineSource.SplineNode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SECTR_SplineSource>.NativeClassPtr, "SplineNode");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_SplineSource.SplineNode>.NativeClassPtr);
				SECTR_SplineSource.SplineNode.NativeFieldInfoPtr_Point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_SplineSource.SplineNode>.NativeClassPtr, "Point");
				SECTR_SplineSource.SplineNode.NativeFieldInfoPtr_Rot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_SplineSource.SplineNode>.NativeClassPtr, "Rot");
				SECTR_SplineSource.SplineNode.NativeFieldInfoPtr_T = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_SplineSource.SplineNode>.NativeClassPtr, "T");
				SECTR_SplineSource.SplineNode.NativeFieldInfoPtr_EaseIO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_SplineSource.SplineNode>.NativeClassPtr, "EaseIO");
				SECTR_SplineSource.SplineNode.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Quaternion_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_SplineSource.SplineNode>.NativeClassPtr, 100664193);
				SECTR_SplineSource.SplineNode.NativeMethodInfoPtr__ctor_Public_Void_SplineNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_SplineSource.SplineNode>.NativeClassPtr, 100664194);
			}

			// Token: 0x06004BAE RID: 19374 RVA: 0x001179CC File Offset: 0x00115BCC
			[CallerCount(0)]
			public unsafe SplineNode(Vector3 p, Quaternion q, float t, Vector2 io)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_SplineSource.SplineNode>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref p;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref q;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref io;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_SplineSource.SplineNode.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Quaternion_Single_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004BAF RID: 19375 RVA: 0x00117A40 File Offset: 0x00115C40
			[CallerCount(0)]
			public unsafe SplineNode(SECTR_SplineSource.SplineNode o)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_SplineSource.SplineNode>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_SplineSource.SplineNode.NativeMethodInfoPtr__ctor_Public_Void_SplineNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004BB0 RID: 19376 RVA: 0x0002C7E6 File Offset: 0x0002A9E6
			public SplineNode(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B8E RID: 7054
			// (get) Token: 0x06004BB1 RID: 19377 RVA: 0x00117A8C File Offset: 0x00115C8C
			// (set) Token: 0x06004BB2 RID: 19378 RVA: 0x0002C7EF File Offset: 0x0002A9EF
			public unsafe Vector3 Point
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_SplineSource.SplineNode.NativeFieldInfoPtr_Point);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_SplineSource.SplineNode.NativeFieldInfoPtr_Point)) = value;
				}
			}

			// Token: 0x17001B8F RID: 7055
			// (get) Token: 0x06004BB3 RID: 19379 RVA: 0x00117AB4 File Offset: 0x00115CB4
			// (set) Token: 0x06004BB4 RID: 19380 RVA: 0x0002C80A File Offset: 0x0002AA0A
			public unsafe Quaternion Rot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_SplineSource.SplineNode.NativeFieldInfoPtr_Rot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_SplineSource.SplineNode.NativeFieldInfoPtr_Rot)) = value;
				}
			}

			// Token: 0x17001B90 RID: 7056
			// (get) Token: 0x06004BB5 RID: 19381 RVA: 0x00117ADC File Offset: 0x00115CDC
			// (set) Token: 0x06004BB6 RID: 19382 RVA: 0x0002C825 File Offset: 0x0002AA25
			public unsafe float T
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_SplineSource.SplineNode.NativeFieldInfoPtr_T);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_SplineSource.SplineNode.NativeFieldInfoPtr_T)) = value;
				}
			}

			// Token: 0x17001B91 RID: 7057
			// (get) Token: 0x06004BB7 RID: 19383 RVA: 0x00117B04 File Offset: 0x00115D04
			// (set) Token: 0x06004BB8 RID: 19384 RVA: 0x0002C840 File Offset: 0x0002AA40
			public unsafe Vector2 EaseIO
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_SplineSource.SplineNode.NativeFieldInfoPtr_EaseIO);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_SplineSource.SplineNode.NativeFieldInfoPtr_EaseIO)) = value;
				}
			}

			// Token: 0x0400319C RID: 12700
			private static readonly IntPtr NativeFieldInfoPtr_Point;

			// Token: 0x0400319D RID: 12701
			private static readonly IntPtr NativeFieldInfoPtr_Rot;

			// Token: 0x0400319E RID: 12702
			private static readonly IntPtr NativeFieldInfoPtr_T;

			// Token: 0x0400319F RID: 12703
			private static readonly IntPtr NativeFieldInfoPtr_EaseIO;

			// Token: 0x040031A0 RID: 12704
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Quaternion_Single_Vector2_0;

			// Token: 0x040031A1 RID: 12705
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SplineNode_0;
		}
	}
}
