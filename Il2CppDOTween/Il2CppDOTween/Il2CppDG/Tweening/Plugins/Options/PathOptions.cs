using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppDG.Tweening.Plugins.Options
{
	// Token: 0x02000031 RID: 49
	public sealed class PathOptions : ValueType
	{
		// Token: 0x0600034C RID: 844 RVA: 0x00017598 File Offset: 0x00015798
		// Note: this type is marked as 'beforefieldinit'.
		static PathOptions()
		{
			Il2CppClassPointerStore<PathOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Options", "PathOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathOptions>.NativeClassPtr);
			PathOptions.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathOptions>.NativeClassPtr, "mode");
			PathOptions.NativeFieldInfoPtr_orientType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathOptions>.NativeClassPtr, "orientType");
			PathOptions.NativeFieldInfoPtr_lockPositionAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathOptions>.NativeClassPtr, "lockPositionAxis");
			PathOptions.NativeFieldInfoPtr_lockRotationAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathOptions>.NativeClassPtr, "lockRotationAxis");
			PathOptions.NativeFieldInfoPtr_isClosedPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathOptions>.NativeClassPtr, "isClosedPath");
			PathOptions.NativeFieldInfoPtr_lookAtPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathOptions>.NativeClassPtr, "lookAtPosition");
			PathOptions.NativeFieldInfoPtr_lookAtTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathOptions>.NativeClassPtr, "lookAtTransform");
			PathOptions.NativeFieldInfoPtr_lookAhead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathOptions>.NativeClassPtr, "lookAhead");
			PathOptions.NativeFieldInfoPtr_hasCustomForwardDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathOptions>.NativeClassPtr, "hasCustomForwardDirection");
			PathOptions.NativeFieldInfoPtr_forward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathOptions>.NativeClassPtr, "forward");
			PathOptions.NativeFieldInfoPtr_useLocalPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathOptions>.NativeClassPtr, "useLocalPosition");
			PathOptions.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathOptions>.NativeClassPtr, "parent");
			PathOptions.NativeFieldInfoPtr_isRigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathOptions>.NativeClassPtr, "isRigidbody");
			PathOptions.NativeFieldInfoPtr_startupRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathOptions>.NativeClassPtr, "startupRot");
			PathOptions.NativeFieldInfoPtr_startupZRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathOptions>.NativeClassPtr, "startupZRot");
			PathOptions.NativeFieldInfoPtr_addedExtraStartWp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathOptions>.NativeClassPtr, "addedExtraStartWp");
			PathOptions.NativeFieldInfoPtr_addedExtraEndWp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathOptions>.NativeClassPtr, "addedExtraEndWp");
			PathOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathOptions>.NativeClassPtr, 100664090);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00017730 File Offset: 0x00015930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123498, XrefRangeEnd = 123504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00002D22 File Offset: 0x00000F22
		public PathOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00002D2B File Offset: 0x00000F2B
		public PathOptions()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathOptions>.NativeClassPtr))
		{
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000350 RID: 848 RVA: 0x00017768 File Offset: 0x00015968
		// (set) Token: 0x06000351 RID: 849 RVA: 0x00002D3D File Offset: 0x00000F3D
		public unsafe PathMode mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_mode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_mode)) = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000352 RID: 850 RVA: 0x00017790 File Offset: 0x00015990
		// (set) Token: 0x06000353 RID: 851 RVA: 0x00002D58 File Offset: 0x00000F58
		public unsafe OrientType orientType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_orientType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_orientType)) = value;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000354 RID: 852 RVA: 0x000177B8 File Offset: 0x000159B8
		// (set) Token: 0x06000355 RID: 853 RVA: 0x00002D73 File Offset: 0x00000F73
		public unsafe AxisConstraint lockPositionAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_lockPositionAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_lockPositionAxis)) = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000356 RID: 854 RVA: 0x000177E0 File Offset: 0x000159E0
		// (set) Token: 0x06000357 RID: 855 RVA: 0x00002D8E File Offset: 0x00000F8E
		public unsafe AxisConstraint lockRotationAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_lockRotationAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_lockRotationAxis)) = value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000358 RID: 856 RVA: 0x00017808 File Offset: 0x00015A08
		// (set) Token: 0x06000359 RID: 857 RVA: 0x00002DA9 File Offset: 0x00000FA9
		public unsafe bool isClosedPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_isClosedPath);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_isClosedPath)) = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600035A RID: 858 RVA: 0x00017830 File Offset: 0x00015A30
		// (set) Token: 0x0600035B RID: 859 RVA: 0x00002DC4 File Offset: 0x00000FC4
		public unsafe Vector3 lookAtPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_lookAtPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_lookAtPosition)) = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600035C RID: 860 RVA: 0x00017858 File Offset: 0x00015A58
		// (set) Token: 0x0600035D RID: 861 RVA: 0x00002DDF File Offset: 0x00000FDF
		public unsafe Transform lookAtTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_lookAtTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_lookAtTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600035E RID: 862 RVA: 0x00017888 File Offset: 0x00015A88
		// (set) Token: 0x0600035F RID: 863 RVA: 0x00002DFE File Offset: 0x00000FFE
		public unsafe float lookAhead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_lookAhead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_lookAhead)) = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000360 RID: 864 RVA: 0x000178B0 File Offset: 0x00015AB0
		// (set) Token: 0x06000361 RID: 865 RVA: 0x00002E19 File Offset: 0x00001019
		public unsafe bool hasCustomForwardDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_hasCustomForwardDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_hasCustomForwardDirection)) = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000362 RID: 866 RVA: 0x000178D8 File Offset: 0x00015AD8
		// (set) Token: 0x06000363 RID: 867 RVA: 0x00002E34 File Offset: 0x00001034
		public unsafe Quaternion forward
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_forward);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_forward)) = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000364 RID: 868 RVA: 0x00017900 File Offset: 0x00015B00
		// (set) Token: 0x06000365 RID: 869 RVA: 0x00002E4F File Offset: 0x0000104F
		public unsafe bool useLocalPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_useLocalPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_useLocalPosition)) = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000366 RID: 870 RVA: 0x00017928 File Offset: 0x00015B28
		// (set) Token: 0x06000367 RID: 871 RVA: 0x00002E6A File Offset: 0x0000106A
		public unsafe Transform parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000368 RID: 872 RVA: 0x00017958 File Offset: 0x00015B58
		// (set) Token: 0x06000369 RID: 873 RVA: 0x00002E89 File Offset: 0x00001089
		public unsafe bool isRigidbody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_isRigidbody);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_isRigidbody)) = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600036A RID: 874 RVA: 0x00017980 File Offset: 0x00015B80
		// (set) Token: 0x0600036B RID: 875 RVA: 0x00002EA4 File Offset: 0x000010A4
		public unsafe Quaternion startupRot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_startupRot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_startupRot)) = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600036C RID: 876 RVA: 0x000179A8 File Offset: 0x00015BA8
		// (set) Token: 0x0600036D RID: 877 RVA: 0x00002EBF File Offset: 0x000010BF
		public unsafe float startupZRot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_startupZRot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_startupZRot)) = value;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600036E RID: 878 RVA: 0x000179D0 File Offset: 0x00015BD0
		// (set) Token: 0x0600036F RID: 879 RVA: 0x00002EDA File Offset: 0x000010DA
		public unsafe bool addedExtraStartWp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_addedExtraStartWp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_addedExtraStartWp)) = value;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000370 RID: 880 RVA: 0x000179F8 File Offset: 0x00015BF8
		// (set) Token: 0x06000371 RID: 881 RVA: 0x00002EF5 File Offset: 0x000010F5
		public unsafe bool addedExtraEndWp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_addedExtraEndWp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_addedExtraEndWp)) = value;
			}
		}

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeFieldInfoPtr_orientType;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeFieldInfoPtr_lockPositionAxis;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeFieldInfoPtr_lockRotationAxis;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeFieldInfoPtr_isClosedPath;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeFieldInfoPtr_lookAtPosition;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeFieldInfoPtr_lookAtTransform;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeFieldInfoPtr_lookAhead;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeFieldInfoPtr_hasCustomForwardDirection;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeFieldInfoPtr_forward;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeFieldInfoPtr_useLocalPosition;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeFieldInfoPtr_isRigidbody;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeFieldInfoPtr_startupRot;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeFieldInfoPtr_startupZRot;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeFieldInfoPtr_addedExtraStartWp;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeFieldInfoPtr_addedExtraEndWp;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
	}
}
