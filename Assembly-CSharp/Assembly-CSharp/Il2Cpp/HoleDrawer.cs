using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200010F RID: 271
	public class HoleDrawer : MonoBehaviour
	{
		// Token: 0x0600203B RID: 8251 RVA: 0x0008E8B4 File Offset: 0x0008CAB4
		// Note: this type is marked as 'beforefieldinit'.
		static HoleDrawer()
		{
			Il2CppClassPointerStore<HoleDrawer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "HoleDrawer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HoleDrawer>.NativeClassPtr);
			HoleDrawer.NativeFieldInfoPtr_topBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoleDrawer>.NativeClassPtr, "topBox");
			HoleDrawer.NativeFieldInfoPtr_bottomBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoleDrawer>.NativeClassPtr, "bottomBox");
			HoleDrawer.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoleDrawer>.NativeClassPtr, "player");
			HoleDrawer.NativeFieldInfoPtr_depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoleDrawer>.NativeClassPtr, "depth");
			HoleDrawer.NativeFieldInfoPtr_sideMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoleDrawer>.NativeClassPtr, "sideMeshes");
			HoleDrawer.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoleDrawer>.NativeClassPtr, "i");
			HoleDrawer.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoleDrawer>.NativeClassPtr, 100665844);
			HoleDrawer.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoleDrawer>.NativeClassPtr, 100665845);
			HoleDrawer.NativeMethodInfoPtr_DrawSide_Public_Void_Vector2_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoleDrawer>.NativeClassPtr, 100665846);
			HoleDrawer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoleDrawer>.NativeClassPtr, 100665847);
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x0008E9AC File Offset: 0x0008CBAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67474, XrefRangeEnd = 67481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoleDrawer.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x0008E9E0 File Offset: 0x0008CBE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67481, XrefRangeEnd = 67625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoleDrawer.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x0008EA14 File Offset: 0x0008CC14
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 67642, RefRangeEnd = 67646, XrefRangeStart = 67625, XrefRangeEnd = 67642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawSide(Vector2 a, Vector2 b, Vector2 c, Vector2 d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoleDrawer.NativeMethodInfoPtr_DrawSide_Public_Void_Vector2_Vector2_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x0008EA7C File Offset: 0x0008CC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HoleDrawer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HoleDrawer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoleDrawer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x0001687D File Offset: 0x00014A7D
		public HoleDrawer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x06002041 RID: 8257 RVA: 0x0008EAB8 File Offset: 0x0008CCB8
		// (set) Token: 0x06002042 RID: 8258 RVA: 0x00016886 File Offset: 0x00014A86
		public unsafe BoxCollider2D topBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoleDrawer.NativeFieldInfoPtr_topBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoleDrawer.NativeFieldInfoPtr_topBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x06002043 RID: 8259 RVA: 0x0008EAE8 File Offset: 0x0008CCE8
		// (set) Token: 0x06002044 RID: 8260 RVA: 0x000168A5 File Offset: 0x00014AA5
		public unsafe BoxCollider2D bottomBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoleDrawer.NativeFieldInfoPtr_bottomBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoleDrawer.NativeFieldInfoPtr_bottomBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x06002045 RID: 8261 RVA: 0x0008EB18 File Offset: 0x0008CD18
		// (set) Token: 0x06002046 RID: 8262 RVA: 0x000168C4 File Offset: 0x00014AC4
		public unsafe GameObject player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoleDrawer.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoleDrawer.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x06002047 RID: 8263 RVA: 0x0008EB48 File Offset: 0x0008CD48
		// (set) Token: 0x06002048 RID: 8264 RVA: 0x000168E3 File Offset: 0x00014AE3
		public unsafe float depth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoleDrawer.NativeFieldInfoPtr_depth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoleDrawer.NativeFieldInfoPtr_depth)) = value;
			}
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x06002049 RID: 8265 RVA: 0x0008EB70 File Offset: 0x0008CD70
		// (set) Token: 0x0600204A RID: 8266 RVA: 0x000168FE File Offset: 0x00014AFE
		public unsafe Il2CppReferenceArray<MeshFilter> sideMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoleDrawer.NativeFieldInfoPtr_sideMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshFilter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoleDrawer.NativeFieldInfoPtr_sideMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x0600204B RID: 8267 RVA: 0x0008EBA0 File Offset: 0x0008CDA0
		// (set) Token: 0x0600204C RID: 8268 RVA: 0x0001691D File Offset: 0x00014B1D
		public unsafe int i
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoleDrawer.NativeFieldInfoPtr_i);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoleDrawer.NativeFieldInfoPtr_i)) = value;
			}
		}

		// Token: 0x0400131E RID: 4894
		private static readonly IntPtr NativeFieldInfoPtr_topBox;

		// Token: 0x0400131F RID: 4895
		private static readonly IntPtr NativeFieldInfoPtr_bottomBox;

		// Token: 0x04001320 RID: 4896
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x04001321 RID: 4897
		private static readonly IntPtr NativeFieldInfoPtr_depth;

		// Token: 0x04001322 RID: 4898
		private static readonly IntPtr NativeFieldInfoPtr_sideMeshes;

		// Token: 0x04001323 RID: 4899
		private static readonly IntPtr NativeFieldInfoPtr_i;

		// Token: 0x04001324 RID: 4900
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04001325 RID: 4901
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04001326 RID: 4902
		private static readonly IntPtr NativeMethodInfoPtr_DrawSide_Public_Void_Vector2_Vector2_Vector2_Vector2_0;

		// Token: 0x04001327 RID: 4903
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
