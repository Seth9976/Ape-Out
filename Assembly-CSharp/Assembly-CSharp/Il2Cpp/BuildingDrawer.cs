using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000090 RID: 144
	public class BuildingDrawer : MonoBehaviour
	{
		// Token: 0x06001156 RID: 4438 RVA: 0x00066494 File Offset: 0x00064694
		// Note: this type is marked as 'beforefieldinit'.
		static BuildingDrawer()
		{
			Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BuildingDrawer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr);
			BuildingDrawer.NativeFieldInfoPtr_dad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "dad");
			BuildingDrawer.NativeFieldInfoPtr_mesher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "mesher");
			BuildingDrawer.NativeFieldInfoPtr_meshRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "meshRend");
			BuildingDrawer.NativeFieldInfoPtr_prevDadx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "prevDadx");
			BuildingDrawer.NativeFieldInfoPtr_startFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "startFlag");
			BuildingDrawer.NativeFieldInfoPtr_offSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "offSet");
			BuildingDrawer.NativeFieldInfoPtr_levelPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "levelPos");
			BuildingDrawer.NativeFieldInfoPtr_pinPts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "pinPts");
			BuildingDrawer.NativeFieldInfoPtr_pinPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "pinPos");
			BuildingDrawer.NativeFieldInfoPtr_verts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "verts");
			BuildingDrawer.NativeFieldInfoPtr_uvs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "uvs");
			BuildingDrawer.NativeFieldInfoPtr_skyVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "skyVerts");
			BuildingDrawer.NativeFieldInfoPtr_windowMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "windowMesh");
			BuildingDrawer.NativeFieldInfoPtr_windowRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "windowRenderer");
			BuildingDrawer.NativeFieldInfoPtr_windowHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "windowHeight");
			BuildingDrawer.NativeFieldInfoPtr_windowNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "windowNum");
			BuildingDrawer.NativeFieldInfoPtr_windowGap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "windowGap");
			BuildingDrawer.NativeFieldInfoPtr_windowColumns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "windowColumns");
			BuildingDrawer.NativeFieldInfoPtr_windows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "windows");
			BuildingDrawer.NativeFieldInfoPtr_windowRends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "windowRends");
			BuildingDrawer.NativeFieldInfoPtr_floors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "floors");
			BuildingDrawer.NativeFieldInfoPtr_autoTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "autoTop");
			BuildingDrawer.NativeFieldInfoPtr_autoBot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "autoBot");
			BuildingDrawer.NativeFieldInfoPtr_minWindowHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "minWindowHeight");
			BuildingDrawer.NativeFieldInfoPtr_overwriteWindowNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "overwriteWindowNum");
			BuildingDrawer.NativeFieldInfoPtr_tileDad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "tileDad");
			BuildingDrawer.NativeFieldInfoPtr_autoXOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "autoXOffset");
			BuildingDrawer.NativeFieldInfoPtr_zeroed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "zeroed");
			BuildingDrawer.NativeFieldInfoPtr_pt1ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "pt1ID");
			BuildingDrawer.NativeFieldInfoPtr_pt2ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "pt2ID");
			BuildingDrawer.NativeFieldInfoPtr_floorID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "floorID");
			BuildingDrawer.NativeFieldInfoPtr_mesherMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "mesherMesh");
			BuildingDrawer.NativeFieldInfoPtr_windowMesherMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "windowMesherMesh");
			BuildingDrawer.NativeFieldInfoPtr_mesherIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "mesherIndex");
			BuildingDrawer.NativeFieldInfoPtr_windowMesherIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "windowMesherIndex");
			BuildingDrawer.NativeFieldInfoPtr_inited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "inited");
			BuildingDrawer.NativeFieldInfoPtr_meshFreed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, "meshFreed");
			BuildingDrawer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, 100664776);
			BuildingDrawer.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, 100664777);
			BuildingDrawer.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, 100664778);
			BuildingDrawer.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, 100664779);
			BuildingDrawer.NativeMethodInfoPtr_GetWindowVerts_Public_Il2CppStructArray_1_Vector3_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, 100664780);
			BuildingDrawer.NativeMethodInfoPtr_Lerp_Private_Void_byref_Single_byref_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, 100664781);
			BuildingDrawer.NativeMethodInfoPtr_GetTopVert_Private_Void_byref_Single_byref_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, 100664782);
			BuildingDrawer.NativeMethodInfoPtr_GetBotVert_Private_Void_byref_Single_byref_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, 100664783);
			BuildingDrawer.NativeMethodInfoPtr_GetTopVert_Private_Vector2_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, 100664784);
			BuildingDrawer.NativeMethodInfoPtr_GetBotVert_Private_Vector2_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, 100664785);
			BuildingDrawer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr, 100664786);
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x00066884 File Offset: 0x00064A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48987, XrefRangeEnd = 49073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildingDrawer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x000668B8 File Offset: 0x00064AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49073, XrefRangeEnd = 49112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildingDrawer.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x000668EC File Offset: 0x00064AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49112, XrefRangeEnd = 49116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildingDrawer.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x00066920 File Offset: 0x00064B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49116, XrefRangeEnd = 49151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildingDrawer.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x00066954 File Offset: 0x00064B54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 49170, RefRangeEnd = 49172, XrefRangeStart = 49151, XrefRangeEnd = 49170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<Vector3> GetWindowVerts(int i, int j)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref j;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildingDrawer.NativeMethodInfoPtr_GetWindowVerts_Public_Il2CppStructArray_1_Vector3_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x000669B0 File Offset: 0x00064BB0
		[CallerCount(0)]
		public unsafe void Lerp(ref float outx, ref float outy, float inx0, float iny0, float inx1, float iny1, float t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &outx;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outy;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inx0;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iny0;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inx1;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iny1;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildingDrawer.NativeMethodInfoPtr_Lerp_Private_Void_byref_Single_byref_Single_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x00066A44 File Offset: 0x00064C44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 49172, RefRangeEnd = 49174, XrefRangeStart = 49172, XrefRangeEnd = 49172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetTopVert(ref float outx, ref float outy, int j, float adder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &outx;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outy;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref j;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref adder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildingDrawer.NativeMethodInfoPtr_GetTopVert_Private_Void_byref_Single_byref_Single_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x00066AAC File Offset: 0x00064CAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 49174, RefRangeEnd = 49176, XrefRangeStart = 49174, XrefRangeEnd = 49174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetBotVert(ref float outx, ref float outy, int j, float adder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &outx;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outy;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref j;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref adder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildingDrawer.NativeMethodInfoPtr_GetBotVert_Private_Void_byref_Single_byref_Single_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x00066B14 File Offset: 0x00064D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49176, XrefRangeEnd = 49181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetTopVert(int j, float adder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref j;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref adder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildingDrawer.NativeMethodInfoPtr_GetTopVert_Private_Vector2_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x00066B6C File Offset: 0x00064D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49181, XrefRangeEnd = 49186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetBotVert(int j, float adder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref j;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref adder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildingDrawer.NativeMethodInfoPtr_GetBotVert_Private_Vector2_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x00066BC4 File Offset: 0x00064DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49186, XrefRangeEnd = 49201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildingDrawer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildingDrawer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildingDrawer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x0000CBBC File Offset: 0x0000ADBC
		public BuildingDrawer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06001163 RID: 4451 RVA: 0x00066C00 File Offset: 0x00064E00
		// (set) Token: 0x06001164 RID: 4452 RVA: 0x0000CBC5 File Offset: 0x0000ADC5
		public unsafe OfficeViewManager dad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_dad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OfficeViewManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_dad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06001165 RID: 4453 RVA: 0x00066C30 File Offset: 0x00064E30
		// (set) Token: 0x06001166 RID: 4454 RVA: 0x0000CBE4 File Offset: 0x0000ADE4
		public unsafe MeshFilter mesher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_mesher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_mesher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06001167 RID: 4455 RVA: 0x00066C60 File Offset: 0x00064E60
		// (set) Token: 0x06001168 RID: 4456 RVA: 0x0000CC03 File Offset: 0x0000AE03
		public unsafe MeshRenderer meshRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_meshRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_meshRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001169 RID: 4457 RVA: 0x00066C90 File Offset: 0x00064E90
		// (set) Token: 0x0600116A RID: 4458 RVA: 0x0000CC22 File Offset: 0x0000AE22
		public unsafe float prevDadx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_prevDadx);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_prevDadx)) = value;
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x0600116B RID: 4459 RVA: 0x00066CB8 File Offset: 0x00064EB8
		// (set) Token: 0x0600116C RID: 4460 RVA: 0x0000CC3D File Offset: 0x0000AE3D
		public unsafe bool startFlag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_startFlag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_startFlag)) = value;
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x0600116D RID: 4461 RVA: 0x00066CE0 File Offset: 0x00064EE0
		// (set) Token: 0x0600116E RID: 4462 RVA: 0x0000CC58 File Offset: 0x0000AE58
		public unsafe float offSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_offSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_offSet)) = value;
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x0600116F RID: 4463 RVA: 0x00066D08 File Offset: 0x00064F08
		// (set) Token: 0x06001170 RID: 4464 RVA: 0x0000CC73 File Offset: 0x0000AE73
		public unsafe Il2CppStructArray<Vector2> levelPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_levelPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_levelPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06001171 RID: 4465 RVA: 0x00066D38 File Offset: 0x00064F38
		// (set) Token: 0x06001172 RID: 4466 RVA: 0x0000CC92 File Offset: 0x0000AE92
		public unsafe Il2CppReferenceArray<Transform> pinPts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_pinPts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_pinPts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06001173 RID: 4467 RVA: 0x00066D68 File Offset: 0x00064F68
		// (set) Token: 0x06001174 RID: 4468 RVA: 0x0000CCB1 File Offset: 0x0000AEB1
		public unsafe Il2CppStructArray<Vector2> pinPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_pinPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_pinPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06001175 RID: 4469 RVA: 0x00066D98 File Offset: 0x00064F98
		// (set) Token: 0x06001176 RID: 4470 RVA: 0x0000CCD0 File Offset: 0x0000AED0
		public unsafe List<Vector3> verts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_verts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_verts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06001177 RID: 4471 RVA: 0x00066DC8 File Offset: 0x00064FC8
		// (set) Token: 0x06001178 RID: 4472 RVA: 0x0000CCEF File Offset: 0x0000AEEF
		public unsafe List<Vector2> uvs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_uvs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_uvs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06001179 RID: 4473 RVA: 0x00066DF8 File Offset: 0x00064FF8
		// (set) Token: 0x0600117A RID: 4474 RVA: 0x0000CD0E File Offset: 0x0000AF0E
		public unsafe Il2CppStructArray<Vector3> skyVerts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_skyVerts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_skyVerts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x0600117B RID: 4475 RVA: 0x00066E28 File Offset: 0x00065028
		// (set) Token: 0x0600117C RID: 4476 RVA: 0x0000CD2D File Offset: 0x0000AF2D
		public unsafe MeshFilter windowMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_windowMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_windowMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x0600117D RID: 4477 RVA: 0x00066E58 File Offset: 0x00065058
		// (set) Token: 0x0600117E RID: 4478 RVA: 0x0000CD4C File Offset: 0x0000AF4C
		public unsafe MeshRenderer windowRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_windowRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_windowRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x0600117F RID: 4479 RVA: 0x00066E88 File Offset: 0x00065088
		// (set) Token: 0x06001180 RID: 4480 RVA: 0x0000CD6B File Offset: 0x0000AF6B
		public unsafe float windowHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_windowHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_windowHeight)) = value;
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06001181 RID: 4481 RVA: 0x00066EB0 File Offset: 0x000650B0
		// (set) Token: 0x06001182 RID: 4482 RVA: 0x0000CD86 File Offset: 0x0000AF86
		public unsafe int windowNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_windowNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_windowNum)) = value;
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06001183 RID: 4483 RVA: 0x00066ED8 File Offset: 0x000650D8
		// (set) Token: 0x06001184 RID: 4484 RVA: 0x0000CDA1 File Offset: 0x0000AFA1
		public unsafe float windowGap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_windowGap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_windowGap)) = value;
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06001185 RID: 4485 RVA: 0x00066F00 File Offset: 0x00065100
		// (set) Token: 0x06001186 RID: 4486 RVA: 0x0000CDBC File Offset: 0x0000AFBC
		public unsafe int windowColumns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_windowColumns);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_windowColumns)) = value;
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06001187 RID: 4487 RVA: 0x00066F28 File Offset: 0x00065128
		// (set) Token: 0x06001188 RID: 4488 RVA: 0x0000CDD7 File Offset: 0x0000AFD7
		public unsafe Il2CppReferenceArray<Il2CppReferenceArray<MeshFilter>> windows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_windows);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppReferenceArray<MeshFilter>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_windows), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06001189 RID: 4489 RVA: 0x00066F58 File Offset: 0x00065158
		// (set) Token: 0x0600118A RID: 4490 RVA: 0x0000CDF6 File Offset: 0x0000AFF6
		public unsafe Il2CppReferenceArray<Il2CppReferenceArray<MeshRenderer>> windowRends
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_windowRends);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppReferenceArray<MeshRenderer>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_windowRends), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x0600118B RID: 4491 RVA: 0x00066F88 File Offset: 0x00065188
		// (set) Token: 0x0600118C RID: 4492 RVA: 0x0000CE15 File Offset: 0x0000B015
		public unsafe int floors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_floors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_floors)) = value;
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x0600118D RID: 4493 RVA: 0x00066FB0 File Offset: 0x000651B0
		// (set) Token: 0x0600118E RID: 4494 RVA: 0x0000CE30 File Offset: 0x0000B030
		public unsafe bool autoTop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_autoTop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_autoTop)) = value;
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x0600118F RID: 4495 RVA: 0x00066FD8 File Offset: 0x000651D8
		// (set) Token: 0x06001190 RID: 4496 RVA: 0x0000CE4B File Offset: 0x0000B04B
		public unsafe bool autoBot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_autoBot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_autoBot)) = value;
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001191 RID: 4497 RVA: 0x00067000 File Offset: 0x00065200
		// (set) Token: 0x06001192 RID: 4498 RVA: 0x0000CE66 File Offset: 0x0000B066
		public unsafe float minWindowHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_minWindowHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_minWindowHeight)) = value;
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001193 RID: 4499 RVA: 0x00067028 File Offset: 0x00065228
		// (set) Token: 0x06001194 RID: 4500 RVA: 0x0000CE81 File Offset: 0x0000B081
		public unsafe int overwriteWindowNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_overwriteWindowNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_overwriteWindowNum)) = value;
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x00067050 File Offset: 0x00065250
		// (set) Token: 0x06001196 RID: 4502 RVA: 0x0000CE9C File Offset: 0x0000B09C
		public unsafe Transform tileDad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_tileDad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_tileDad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001197 RID: 4503 RVA: 0x00067080 File Offset: 0x00065280
		// (set) Token: 0x06001198 RID: 4504 RVA: 0x0000CEBB File Offset: 0x0000B0BB
		public unsafe float autoXOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_autoXOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_autoXOffset)) = value;
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001199 RID: 4505 RVA: 0x000670A8 File Offset: 0x000652A8
		// (set) Token: 0x0600119A RID: 4506 RVA: 0x0000CED6 File Offset: 0x0000B0D6
		public unsafe bool zeroed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_zeroed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_zeroed)) = value;
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x0600119B RID: 4507 RVA: 0x000670D0 File Offset: 0x000652D0
		// (set) Token: 0x0600119C RID: 4508 RVA: 0x0000CEF1 File Offset: 0x0000B0F1
		public unsafe int pt1ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_pt1ID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_pt1ID)) = value;
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x0600119D RID: 4509 RVA: 0x000670F8 File Offset: 0x000652F8
		// (set) Token: 0x0600119E RID: 4510 RVA: 0x0000CF0C File Offset: 0x0000B10C
		public unsafe int pt2ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_pt2ID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_pt2ID)) = value;
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x0600119F RID: 4511 RVA: 0x00067120 File Offset: 0x00065320
		// (set) Token: 0x060011A0 RID: 4512 RVA: 0x0000CF27 File Offset: 0x0000B127
		public unsafe int floorID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_floorID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_floorID)) = value;
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x060011A1 RID: 4513 RVA: 0x00067148 File Offset: 0x00065348
		// (set) Token: 0x060011A2 RID: 4514 RVA: 0x0000CF42 File Offset: 0x0000B142
		public unsafe Mesh mesherMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_mesherMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_mesherMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x060011A3 RID: 4515 RVA: 0x00067178 File Offset: 0x00065378
		// (set) Token: 0x060011A4 RID: 4516 RVA: 0x0000CF61 File Offset: 0x0000B161
		public unsafe Mesh windowMesherMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_windowMesherMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_windowMesherMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x060011A5 RID: 4517 RVA: 0x000671A8 File Offset: 0x000653A8
		// (set) Token: 0x060011A6 RID: 4518 RVA: 0x0000CF80 File Offset: 0x0000B180
		public unsafe int mesherIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_mesherIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_mesherIndex)) = value;
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x060011A7 RID: 4519 RVA: 0x000671D0 File Offset: 0x000653D0
		// (set) Token: 0x060011A8 RID: 4520 RVA: 0x0000CF9B File Offset: 0x0000B19B
		public unsafe int windowMesherIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_windowMesherIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_windowMesherIndex)) = value;
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x060011A9 RID: 4521 RVA: 0x000671F8 File Offset: 0x000653F8
		// (set) Token: 0x060011AA RID: 4522 RVA: 0x0000CFB6 File Offset: 0x0000B1B6
		public unsafe bool inited
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_inited);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_inited)) = value;
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x060011AB RID: 4523 RVA: 0x00067220 File Offset: 0x00065420
		// (set) Token: 0x060011AC RID: 4524 RVA: 0x0000CFD1 File Offset: 0x0000B1D1
		public unsafe bool meshFreed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_meshFreed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingDrawer.NativeFieldInfoPtr_meshFreed)) = value;
			}
		}

		// Token: 0x04000A7A RID: 2682
		private static readonly IntPtr NativeFieldInfoPtr_dad;

		// Token: 0x04000A7B RID: 2683
		private static readonly IntPtr NativeFieldInfoPtr_mesher;

		// Token: 0x04000A7C RID: 2684
		private static readonly IntPtr NativeFieldInfoPtr_meshRend;

		// Token: 0x04000A7D RID: 2685
		private static readonly IntPtr NativeFieldInfoPtr_prevDadx;

		// Token: 0x04000A7E RID: 2686
		private static readonly IntPtr NativeFieldInfoPtr_startFlag;

		// Token: 0x04000A7F RID: 2687
		private static readonly IntPtr NativeFieldInfoPtr_offSet;

		// Token: 0x04000A80 RID: 2688
		private static readonly IntPtr NativeFieldInfoPtr_levelPos;

		// Token: 0x04000A81 RID: 2689
		private static readonly IntPtr NativeFieldInfoPtr_pinPts;

		// Token: 0x04000A82 RID: 2690
		private static readonly IntPtr NativeFieldInfoPtr_pinPos;

		// Token: 0x04000A83 RID: 2691
		private static readonly IntPtr NativeFieldInfoPtr_verts;

		// Token: 0x04000A84 RID: 2692
		private static readonly IntPtr NativeFieldInfoPtr_uvs;

		// Token: 0x04000A85 RID: 2693
		private static readonly IntPtr NativeFieldInfoPtr_skyVerts;

		// Token: 0x04000A86 RID: 2694
		private static readonly IntPtr NativeFieldInfoPtr_windowMesh;

		// Token: 0x04000A87 RID: 2695
		private static readonly IntPtr NativeFieldInfoPtr_windowRenderer;

		// Token: 0x04000A88 RID: 2696
		private static readonly IntPtr NativeFieldInfoPtr_windowHeight;

		// Token: 0x04000A89 RID: 2697
		private static readonly IntPtr NativeFieldInfoPtr_windowNum;

		// Token: 0x04000A8A RID: 2698
		private static readonly IntPtr NativeFieldInfoPtr_windowGap;

		// Token: 0x04000A8B RID: 2699
		private static readonly IntPtr NativeFieldInfoPtr_windowColumns;

		// Token: 0x04000A8C RID: 2700
		private static readonly IntPtr NativeFieldInfoPtr_windows;

		// Token: 0x04000A8D RID: 2701
		private static readonly IntPtr NativeFieldInfoPtr_windowRends;

		// Token: 0x04000A8E RID: 2702
		private static readonly IntPtr NativeFieldInfoPtr_floors;

		// Token: 0x04000A8F RID: 2703
		private static readonly IntPtr NativeFieldInfoPtr_autoTop;

		// Token: 0x04000A90 RID: 2704
		private static readonly IntPtr NativeFieldInfoPtr_autoBot;

		// Token: 0x04000A91 RID: 2705
		private static readonly IntPtr NativeFieldInfoPtr_minWindowHeight;

		// Token: 0x04000A92 RID: 2706
		private static readonly IntPtr NativeFieldInfoPtr_overwriteWindowNum;

		// Token: 0x04000A93 RID: 2707
		private static readonly IntPtr NativeFieldInfoPtr_tileDad;

		// Token: 0x04000A94 RID: 2708
		private static readonly IntPtr NativeFieldInfoPtr_autoXOffset;

		// Token: 0x04000A95 RID: 2709
		private static readonly IntPtr NativeFieldInfoPtr_zeroed;

		// Token: 0x04000A96 RID: 2710
		private static readonly IntPtr NativeFieldInfoPtr_pt1ID;

		// Token: 0x04000A97 RID: 2711
		private static readonly IntPtr NativeFieldInfoPtr_pt2ID;

		// Token: 0x04000A98 RID: 2712
		private static readonly IntPtr NativeFieldInfoPtr_floorID;

		// Token: 0x04000A99 RID: 2713
		private static readonly IntPtr NativeFieldInfoPtr_mesherMesh;

		// Token: 0x04000A9A RID: 2714
		private static readonly IntPtr NativeFieldInfoPtr_windowMesherMesh;

		// Token: 0x04000A9B RID: 2715
		private static readonly IntPtr NativeFieldInfoPtr_mesherIndex;

		// Token: 0x04000A9C RID: 2716
		private static readonly IntPtr NativeFieldInfoPtr_windowMesherIndex;

		// Token: 0x04000A9D RID: 2717
		private static readonly IntPtr NativeFieldInfoPtr_inited;

		// Token: 0x04000A9E RID: 2718
		private static readonly IntPtr NativeFieldInfoPtr_meshFreed;

		// Token: 0x04000A9F RID: 2719
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000AA0 RID: 2720
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000AA1 RID: 2721
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000AA2 RID: 2722
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04000AA3 RID: 2723
		private static readonly IntPtr NativeMethodInfoPtr_GetWindowVerts_Public_Il2CppStructArray_1_Vector3_Int32_Int32_0;

		// Token: 0x04000AA4 RID: 2724
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Private_Void_byref_Single_byref_Single_Single_Single_Single_Single_Single_0;

		// Token: 0x04000AA5 RID: 2725
		private static readonly IntPtr NativeMethodInfoPtr_GetTopVert_Private_Void_byref_Single_byref_Single_Int32_Single_0;

		// Token: 0x04000AA6 RID: 2726
		private static readonly IntPtr NativeMethodInfoPtr_GetBotVert_Private_Void_byref_Single_byref_Single_Int32_Single_0;

		// Token: 0x04000AA7 RID: 2727
		private static readonly IntPtr NativeMethodInfoPtr_GetTopVert_Private_Vector2_Int32_Single_0;

		// Token: 0x04000AA8 RID: 2728
		private static readonly IntPtr NativeMethodInfoPtr_GetBotVert_Private_Vector2_Int32_Single_0;

		// Token: 0x04000AA9 RID: 2729
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
