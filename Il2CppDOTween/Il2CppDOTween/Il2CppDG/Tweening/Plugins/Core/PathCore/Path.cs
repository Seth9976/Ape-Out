using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppDG.Tweening.Plugins.Core.PathCore
{
	// Token: 0x02000046 RID: 70
	[Serializable]
	public class Path : global::Il2CppSystem.Object
	{
		// Token: 0x0600040A RID: 1034 RVA: 0x00019C08 File Offset: 0x00017E08
		// Note: this type is marked as 'beforefieldinit'.
		static Path()
		{
			Il2CppClassPointerStore<Path>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Core.PathCore", "Path");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Path>.NativeClassPtr);
			Path.NativeFieldInfoPtr__catmullRomDecoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "_catmullRomDecoder");
			Path.NativeFieldInfoPtr__linearDecoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "_linearDecoder");
			Path.NativeFieldInfoPtr__cubicBezierDecoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "_cubicBezierDecoder");
			Path.NativeFieldInfoPtr_wpLengths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "wpLengths");
			Path.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "type");
			Path.NativeFieldInfoPtr_subdivisionsXSegment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "subdivisionsXSegment");
			Path.NativeFieldInfoPtr_subdivisions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "subdivisions");
			Path.NativeFieldInfoPtr_wps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "wps");
			Path.NativeFieldInfoPtr_controlPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "controlPoints");
			Path.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "length");
			Path.NativeFieldInfoPtr_isFinalized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "isFinalized");
			Path.NativeFieldInfoPtr_timesTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "timesTable");
			Path.NativeFieldInfoPtr_lengthsTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "lengthsTable");
			Path.NativeFieldInfoPtr_linearWPIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "linearWPIndex");
			Path.NativeFieldInfoPtr_addedExtraStartWp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "addedExtraStartWp");
			Path.NativeFieldInfoPtr_addedExtraEndWp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "addedExtraEndWp");
			Path.NativeFieldInfoPtr__incrementalClone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "_incrementalClone");
			Path.NativeFieldInfoPtr__incrementalIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "_incrementalIndex");
			Path.NativeFieldInfoPtr__decoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "_decoder");
			Path.NativeFieldInfoPtr__changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "_changed");
			Path.NativeFieldInfoPtr_nonLinearDrawWps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "nonLinearDrawWps");
			Path.NativeFieldInfoPtr_targetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "targetPosition");
			Path.NativeFieldInfoPtr_lookAtPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "lookAtPosition");
			Path.NativeFieldInfoPtr_gizmoColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "gizmoColor");
			Path.NativeMethodInfoPtr__ctor_Public_Void_PathType_Il2CppStructArray_1_Vector3_Int32_Nullable_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100664143);
			Path.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100664144);
			Path.NativeMethodInfoPtr_FinalizePath_Internal_Void_Boolean_AxisConstraint_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100664145);
			Path.NativeMethodInfoPtr_GetPoint_Internal_Vector3_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100664146);
			Path.NativeMethodInfoPtr_ConvertToConstantPathPerc_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100664147);
			Path.NativeMethodInfoPtr_GetWaypointIndexFromPerc_Internal_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100664148);
			Path.NativeMethodInfoPtr_GetDrawPoints_Internal_Static_Il2CppStructArray_1_Vector3_Path_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100664149);
			Path.NativeMethodInfoPtr_RefreshNonLinearDrawWps_Internal_Static_Void_Path_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100664150);
			Path.NativeMethodInfoPtr_Destroy_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100664151);
			Path.NativeMethodInfoPtr_CloneIncremental_Internal_Path_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100664152);
			Path.NativeMethodInfoPtr_AssignWaypoints_Internal_Void_Il2CppStructArray_1_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100664153);
			Path.NativeMethodInfoPtr_AssignDecoder_Internal_Void_PathType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100664154);
			Path.NativeMethodInfoPtr_Draw_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100664155);
			Path.NativeMethodInfoPtr_Draw_Private_Static_Void_Path_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100664156);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00019F30 File Offset: 0x00018130
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 124028, RefRangeEnd = 124032, XrefRangeStart = 124006, XrefRangeEnd = 124028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Path(PathType type, Il2CppStructArray<Vector3> waypoints, int subdivisionsXSegment, Nullable<Color> gizmoColor = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Path>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(waypoints);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref subdivisionsXSegment;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(gizmoColor));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr__ctor_Public_Void_PathType_Il2CppStructArray_1_Vector3_Int32_Nullable_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00019FB0 File Offset: 0x000181B0
		[CallerCount(0)]
		public unsafe Path()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Path>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00019FEC File Offset: 0x000181EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124032, XrefRangeEnd = 124036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinalizePath(bool isClosedPath, AxisConstraint lockPositionAxes, Vector3 currTargetVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isClosedPath;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lockPositionAxes;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currTargetVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_FinalizePath_Internal_Void_Boolean_AxisConstraint_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0001A048 File Offset: 0x00018248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124036, XrefRangeEnd = 124037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPoint(float perc, bool convertToConstantPerc = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref perc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref convertToConstantPerc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetPoint_Internal_Vector3_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0001A0A0 File Offset: 0x000182A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 124037, RefRangeEnd = 124040, XrefRangeStart = 124037, XrefRangeEnd = 124037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ConvertToConstantPathPerc(float perc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref perc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_ConvertToConstantPathPerc_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0001A0EC File Offset: 0x000182EC
		[CallerCount(0)]
		public unsafe int GetWaypointIndexFromPerc(float perc, bool isMovingForward)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref perc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isMovingForward;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetWaypointIndexFromPerc_Internal_Int32_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0001A144 File Offset: 0x00018344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124040, XrefRangeEnd = 124043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<Vector3> GetDrawPoints(Path p, int drawSubdivisionsXSegment)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drawSubdivisionsXSegment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetDrawPoints_Internal_Static_Il2CppStructArray_1_Vector3_Path_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0001A198 File Offset: 0x00018398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124043, XrefRangeEnd = 124046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RefreshNonLinearDrawWps(Path p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_RefreshNonLinearDrawWps_Internal_Static_Void_Path_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0001A1D0 File Offset: 0x000183D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 124061, RefRangeEnd = 124063, XrefRangeStart = 124046, XrefRangeEnd = 124061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_Destroy_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0001A204 File Offset: 0x00018404
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124091, RefRangeEnd = 124092, XrefRangeStart = 124063, XrefRangeEnd = 124091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Path CloneIncremental(int loopIncrement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref loopIncrement;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_CloneIncremental_Internal_Path_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Path>(intPtr3) : null;
			}
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0001A250 File Offset: 0x00018450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124092, XrefRangeEnd = 124093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignWaypoints(Il2CppStructArray<Vector3> newWps, bool cloneWps = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newWps);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cloneWps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_AssignWaypoints_Internal_Void_Il2CppStructArray_1_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0001A2A0 File Offset: 0x000184A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124102, RefRangeEnd = 124103, XrefRangeStart = 124093, XrefRangeEnd = 124102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignDecoder(PathType pathType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pathType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_AssignDecoder_Internal_Void_PathType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0001A2E0 File Offset: 0x000184E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124103, XrefRangeEnd = 124104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Draw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_Draw_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0001A314 File Offset: 0x00018514
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124125, RefRangeEnd = 124126, XrefRangeStart = 124104, XrefRangeEnd = 124125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Draw(Path p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_Draw_Private_Static_Void_Path_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x000032EC File Offset: 0x000014EC
		public Path(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x0001A34C File Offset: 0x0001854C
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x000032F5 File Offset: 0x000014F5
		public unsafe static CatmullRomDecoder _catmullRomDecoder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr__catmullRomDecoder, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CatmullRomDecoder>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr__catmullRomDecoder, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x0001A374 File Offset: 0x00018574
		// (set) Token: 0x0600041D RID: 1053 RVA: 0x00003307 File Offset: 0x00001507
		public unsafe static LinearDecoder _linearDecoder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr__linearDecoder, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinearDecoder>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr__linearDecoder, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x0001A39C File Offset: 0x0001859C
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x00003319 File Offset: 0x00001519
		public unsafe static CubicBezierDecoder _cubicBezierDecoder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr__cubicBezierDecoder, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CubicBezierDecoder>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr__cubicBezierDecoder, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x0001A3C4 File Offset: 0x000185C4
		// (set) Token: 0x06000421 RID: 1057 RVA: 0x0000332B File Offset: 0x0000152B
		public unsafe Il2CppStructArray<float> wpLengths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_wpLengths);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_wpLengths), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x0001A3F4 File Offset: 0x000185F4
		// (set) Token: 0x06000423 RID: 1059 RVA: 0x0000334A File Offset: 0x0000154A
		public unsafe PathType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x0001A41C File Offset: 0x0001861C
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x00003365 File Offset: 0x00001565
		public unsafe int subdivisionsXSegment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_subdivisionsXSegment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_subdivisionsXSegment)) = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x0001A444 File Offset: 0x00018644
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x00003380 File Offset: 0x00001580
		public unsafe int subdivisions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_subdivisions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_subdivisions)) = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x0001A46C File Offset: 0x0001866C
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x0000339B File Offset: 0x0000159B
		public unsafe Il2CppStructArray<Vector3> wps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_wps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_wps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x0001A49C File Offset: 0x0001869C
		// (set) Token: 0x0600042B RID: 1067 RVA: 0x000033BA File Offset: 0x000015BA
		public unsafe Il2CppStructArray<ControlPoint> controlPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_controlPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ControlPoint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_controlPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x0001A4CC File Offset: 0x000186CC
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x000033D9 File Offset: 0x000015D9
		public unsafe float length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_length)) = value;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x0001A4F4 File Offset: 0x000186F4
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x000033F4 File Offset: 0x000015F4
		public unsafe bool isFinalized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_isFinalized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_isFinalized)) = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x0001A51C File Offset: 0x0001871C
		// (set) Token: 0x06000431 RID: 1073 RVA: 0x0000340F File Offset: 0x0000160F
		public unsafe Il2CppStructArray<float> timesTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_timesTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_timesTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x0001A54C File Offset: 0x0001874C
		// (set) Token: 0x06000433 RID: 1075 RVA: 0x0000342E File Offset: 0x0000162E
		public unsafe Il2CppStructArray<float> lengthsTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_lengthsTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_lengthsTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x0001A57C File Offset: 0x0001877C
		// (set) Token: 0x06000435 RID: 1077 RVA: 0x0000344D File Offset: 0x0000164D
		public unsafe int linearWPIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_linearWPIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_linearWPIndex)) = value;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x0001A5A4 File Offset: 0x000187A4
		// (set) Token: 0x06000437 RID: 1079 RVA: 0x00003468 File Offset: 0x00001668
		public unsafe bool addedExtraStartWp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_addedExtraStartWp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_addedExtraStartWp)) = value;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x0001A5CC File Offset: 0x000187CC
		// (set) Token: 0x06000439 RID: 1081 RVA: 0x00003483 File Offset: 0x00001683
		public unsafe bool addedExtraEndWp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_addedExtraEndWp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_addedExtraEndWp)) = value;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x0001A5F4 File Offset: 0x000187F4
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x0000349E File Offset: 0x0000169E
		public unsafe Path _incrementalClone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr__incrementalClone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Path>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr__incrementalClone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x0001A624 File Offset: 0x00018824
		// (set) Token: 0x0600043D RID: 1085 RVA: 0x000034BD File Offset: 0x000016BD
		public unsafe int _incrementalIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr__incrementalIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr__incrementalIndex)) = value;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x0001A64C File Offset: 0x0001884C
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x000034D8 File Offset: 0x000016D8
		public unsafe ABSPathDecoder _decoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr__decoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ABSPathDecoder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr__decoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x0001A67C File Offset: 0x0001887C
		// (set) Token: 0x06000441 RID: 1089 RVA: 0x000034F7 File Offset: 0x000016F7
		public unsafe bool _changed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr__changed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr__changed)) = value;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x0001A6A4 File Offset: 0x000188A4
		// (set) Token: 0x06000443 RID: 1091 RVA: 0x00003512 File Offset: 0x00001712
		public unsafe Il2CppStructArray<Vector3> nonLinearDrawWps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_nonLinearDrawWps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_nonLinearDrawWps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x0001A6D4 File Offset: 0x000188D4
		// (set) Token: 0x06000445 RID: 1093 RVA: 0x00003531 File Offset: 0x00001731
		public unsafe Vector3 targetPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_targetPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_targetPosition)) = value;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x0001A6FC File Offset: 0x000188FC
		// (set) Token: 0x06000447 RID: 1095 RVA: 0x0000354C File Offset: 0x0000174C
		public Nullable<Vector3> lookAtPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_lookAtPosition);
				return new Nullable<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Vector3>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_lookAtPosition), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Vector3>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x0001A72C File Offset: 0x0001892C
		// (set) Token: 0x06000449 RID: 1097 RVA: 0x0000357A File Offset: 0x0000177A
		public unsafe Color gizmoColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_gizmoColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_gizmoColor)) = value;
			}
		}

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeFieldInfoPtr__catmullRomDecoder;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeFieldInfoPtr__linearDecoder;

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeFieldInfoPtr__cubicBezierDecoder;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeFieldInfoPtr_wpLengths;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeFieldInfoPtr_subdivisionsXSegment;

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeFieldInfoPtr_subdivisions;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeFieldInfoPtr_wps;

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeFieldInfoPtr_controlPoints;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeFieldInfoPtr_isFinalized;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeFieldInfoPtr_timesTable;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeFieldInfoPtr_lengthsTable;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeFieldInfoPtr_linearWPIndex;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeFieldInfoPtr_addedExtraStartWp;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeFieldInfoPtr_addedExtraEndWp;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeFieldInfoPtr__incrementalClone;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeFieldInfoPtr__incrementalIndex;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeFieldInfoPtr__decoder;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeFieldInfoPtr__changed;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeFieldInfoPtr_nonLinearDrawWps;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeFieldInfoPtr_targetPosition;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeFieldInfoPtr_lookAtPosition;

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeFieldInfoPtr_gizmoColor;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PathType_Il2CppStructArray_1_Vector3_Int32_Nullable_1_Color_0;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeMethodInfoPtr_FinalizePath_Internal_Void_Boolean_AxisConstraint_Vector3_0;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeMethodInfoPtr_GetPoint_Internal_Vector3_Single_Boolean_0;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToConstantPathPerc_Internal_Single_Single_0;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeMethodInfoPtr_GetWaypointIndexFromPerc_Internal_Int32_Single_Boolean_0;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeMethodInfoPtr_GetDrawPoints_Internal_Static_Il2CppStructArray_1_Vector3_Path_Int32_0;

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeMethodInfoPtr_RefreshNonLinearDrawWps_Internal_Static_Void_Path_0;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Internal_Void_0;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeMethodInfoPtr_CloneIncremental_Internal_Path_Int32_0;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeMethodInfoPtr_AssignWaypoints_Internal_Void_Il2CppStructArray_1_Vector3_Boolean_0;

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeMethodInfoPtr_AssignDecoder_Internal_Void_PathType_0;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeMethodInfoPtr_Draw_Internal_Void_0;

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeMethodInfoPtr_Draw_Private_Static_Void_Path_0;
	}
}
