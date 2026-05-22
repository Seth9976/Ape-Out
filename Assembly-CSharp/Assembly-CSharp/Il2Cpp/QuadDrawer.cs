using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200016B RID: 363
	public class QuadDrawer : MonoBehaviour
	{
		// Token: 0x06002BC1 RID: 11201 RVA: 0x000AD444 File Offset: 0x000AB644
		// Note: this type is marked as 'beforefieldinit'.
		static QuadDrawer()
		{
			Il2CppClassPointerStore<QuadDrawer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "QuadDrawer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuadDrawer>.NativeClassPtr);
			QuadDrawer.NativeFieldInfoPtr_meshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadDrawer>.NativeClassPtr, "meshes");
			QuadDrawer.NativeFieldInfoPtr_meshTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadDrawer>.NativeClassPtr, "meshTransform");
			QuadDrawer.NativeFieldInfoPtr_verts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadDrawer>.NativeClassPtr, "verts");
			QuadDrawer.NativeFieldInfoPtr_mesher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadDrawer>.NativeClassPtr, "mesher");
			QuadDrawer.NativeFieldInfoPtr_vts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadDrawer>.NativeClassPtr, "vts");
			QuadDrawer.NativeFieldInfoPtr_vts2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadDrawer>.NativeClassPtr, "vts2");
			QuadDrawer.NativeFieldInfoPtr_mshVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadDrawer>.NativeClassPtr, "mshVerts");
			QuadDrawer.NativeFieldInfoPtr_zeroed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadDrawer>.NativeClassPtr, "zeroed");
			QuadDrawer.NativeFieldInfoPtr_defPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadDrawer>.NativeClassPtr, "defPos");
			QuadDrawer.NativeFieldInfoPtr_offSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadDrawer>.NativeClassPtr, "offSets");
			QuadDrawer.NativeFieldInfoPtr_mesherMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadDrawer>.NativeClassPtr, "mesherMesh");
			QuadDrawer.NativeFieldInfoPtr_mesherIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadDrawer>.NativeClassPtr, "mesherIndex");
			QuadDrawer.NativeFieldInfoPtr_rend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadDrawer>.NativeClassPtr, "rend");
			QuadDrawer.NativeFieldInfoPtr_off = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadDrawer>.NativeClassPtr, "off");
			QuadDrawer.NativeFieldInfoPtr_rTechs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadDrawer>.NativeClassPtr, "rTechs");
			QuadDrawer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadDrawer>.NativeClassPtr, 100666734);
			QuadDrawer.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadDrawer>.NativeClassPtr, 100666735);
			QuadDrawer.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadDrawer>.NativeClassPtr, 100666736);
			QuadDrawer.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadDrawer>.NativeClassPtr, 100666737);
			QuadDrawer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadDrawer>.NativeClassPtr, 100666738);
		}

		// Token: 0x06002BC2 RID: 11202 RVA: 0x000AD604 File Offset: 0x000AB804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79648, XrefRangeEnd = 79689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadDrawer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BC3 RID: 11203 RVA: 0x000AD638 File Offset: 0x000AB838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79689, XrefRangeEnd = 79741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadDrawer.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BC4 RID: 11204 RVA: 0x000AD66C File Offset: 0x000AB86C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79741, XrefRangeEnd = 79747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadDrawer.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BC5 RID: 11205 RVA: 0x000AD6A0 File Offset: 0x000AB8A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79747, XrefRangeEnd = 79796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadDrawer.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BC6 RID: 11206 RVA: 0x000AD6D4 File Offset: 0x000AB8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79796, XrefRangeEnd = 79805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuadDrawer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuadDrawer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadDrawer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BC7 RID: 11207 RVA: 0x0001E543 File Offset: 0x0001C743
		public QuadDrawer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FB9 RID: 4025
		// (get) Token: 0x06002BC8 RID: 11208 RVA: 0x000AD710 File Offset: 0x000AB910
		// (set) Token: 0x06002BC9 RID: 11209 RVA: 0x0001E54C File Offset: 0x0001C74C
		public unsafe Il2CppReferenceArray<MeshFilter> meshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadDrawer.NativeFieldInfoPtr_meshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshFilter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadDrawer.NativeFieldInfoPtr_meshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FBA RID: 4026
		// (get) Token: 0x06002BCA RID: 11210 RVA: 0x000AD740 File Offset: 0x000AB940
		// (set) Token: 0x06002BCB RID: 11211 RVA: 0x0001E56B File Offset: 0x0001C76B
		public unsafe Il2CppReferenceArray<Transform> meshTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadDrawer.NativeFieldInfoPtr_meshTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadDrawer.NativeFieldInfoPtr_meshTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FBB RID: 4027
		// (get) Token: 0x06002BCC RID: 11212 RVA: 0x000AD770 File Offset: 0x000AB970
		// (set) Token: 0x06002BCD RID: 11213 RVA: 0x0001E58A File Offset: 0x0001C78A
		public unsafe Il2CppStructArray<int> verts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadDrawer.NativeFieldInfoPtr_verts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadDrawer.NativeFieldInfoPtr_verts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FBC RID: 4028
		// (get) Token: 0x06002BCE RID: 11214 RVA: 0x000AD7A0 File Offset: 0x000AB9A0
		// (set) Token: 0x06002BCF RID: 11215 RVA: 0x0001E5A9 File Offset: 0x0001C7A9
		public unsafe MeshFilter mesher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadDrawer.NativeFieldInfoPtr_mesher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadDrawer.NativeFieldInfoPtr_mesher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FBD RID: 4029
		// (get) Token: 0x06002BD0 RID: 11216 RVA: 0x000AD7D0 File Offset: 0x000AB9D0
		// (set) Token: 0x06002BD1 RID: 11217 RVA: 0x0001E5C8 File Offset: 0x0001C7C8
		public unsafe List<Vector3> vts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadDrawer.NativeFieldInfoPtr_vts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadDrawer.NativeFieldInfoPtr_vts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FBE RID: 4030
		// (get) Token: 0x06002BD2 RID: 11218 RVA: 0x000AD800 File Offset: 0x000ABA00
		// (set) Token: 0x06002BD3 RID: 11219 RVA: 0x0001E5E7 File Offset: 0x0001C7E7
		public unsafe List<Vector3> vts2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadDrawer.NativeFieldInfoPtr_vts2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadDrawer.NativeFieldInfoPtr_vts2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FBF RID: 4031
		// (get) Token: 0x06002BD4 RID: 11220 RVA: 0x000AD830 File Offset: 0x000ABA30
		// (set) Token: 0x06002BD5 RID: 11221 RVA: 0x0001E606 File Offset: 0x0001C806
		public unsafe Il2CppStructArray<Vector3> mshVerts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadDrawer.NativeFieldInfoPtr_mshVerts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadDrawer.NativeFieldInfoPtr_mshVerts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FC0 RID: 4032
		// (get) Token: 0x06002BD6 RID: 11222 RVA: 0x000AD860 File Offset: 0x000ABA60
		// (set) Token: 0x06002BD7 RID: 11223 RVA: 0x0001E625 File Offset: 0x0001C825
		public unsafe bool zeroed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadDrawer.NativeFieldInfoPtr_zeroed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadDrawer.NativeFieldInfoPtr_zeroed)) = value;
			}
		}

		// Token: 0x17000FC1 RID: 4033
		// (get) Token: 0x06002BD8 RID: 11224 RVA: 0x000AD888 File Offset: 0x000ABA88
		// (set) Token: 0x06002BD9 RID: 11225 RVA: 0x0001E640 File Offset: 0x0001C840
		public unsafe Vector2 defPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadDrawer.NativeFieldInfoPtr_defPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadDrawer.NativeFieldInfoPtr_defPos)) = value;
			}
		}

		// Token: 0x17000FC2 RID: 4034
		// (get) Token: 0x06002BDA RID: 11226 RVA: 0x000AD8B0 File Offset: 0x000ABAB0
		// (set) Token: 0x06002BDB RID: 11227 RVA: 0x0001E65B File Offset: 0x0001C85B
		public unsafe Il2CppStructArray<Vector3> offSets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadDrawer.NativeFieldInfoPtr_offSets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadDrawer.NativeFieldInfoPtr_offSets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FC3 RID: 4035
		// (get) Token: 0x06002BDC RID: 11228 RVA: 0x000AD8E0 File Offset: 0x000ABAE0
		// (set) Token: 0x06002BDD RID: 11229 RVA: 0x0001E67A File Offset: 0x0001C87A
		public unsafe Mesh mesherMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadDrawer.NativeFieldInfoPtr_mesherMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadDrawer.NativeFieldInfoPtr_mesherMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x06002BDE RID: 11230 RVA: 0x000AD910 File Offset: 0x000ABB10
		// (set) Token: 0x06002BDF RID: 11231 RVA: 0x0001E699 File Offset: 0x0001C899
		public unsafe int mesherIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadDrawer.NativeFieldInfoPtr_mesherIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadDrawer.NativeFieldInfoPtr_mesherIndex)) = value;
			}
		}

		// Token: 0x17000FC5 RID: 4037
		// (get) Token: 0x06002BE0 RID: 11232 RVA: 0x000AD938 File Offset: 0x000ABB38
		// (set) Token: 0x06002BE1 RID: 11233 RVA: 0x0001E6B4 File Offset: 0x0001C8B4
		public unsafe MeshRenderer rend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadDrawer.NativeFieldInfoPtr_rend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadDrawer.NativeFieldInfoPtr_rend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FC6 RID: 4038
		// (get) Token: 0x06002BE2 RID: 11234 RVA: 0x000AD968 File Offset: 0x000ABB68
		// (set) Token: 0x06002BE3 RID: 11235 RVA: 0x0001E6D3 File Offset: 0x0001C8D3
		public unsafe bool off
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadDrawer.NativeFieldInfoPtr_off);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadDrawer.NativeFieldInfoPtr_off)) = value;
			}
		}

		// Token: 0x17000FC7 RID: 4039
		// (get) Token: 0x06002BE4 RID: 11236 RVA: 0x000AD990 File Offset: 0x000ABB90
		// (set) Token: 0x06002BE5 RID: 11237 RVA: 0x0001E6EE File Offset: 0x0001C8EE
		public unsafe Il2CppReferenceArray<RockTech> rTechs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadDrawer.NativeFieldInfoPtr_rTechs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RockTech>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadDrawer.NativeFieldInfoPtr_rTechs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019CD RID: 6605
		private static readonly IntPtr NativeFieldInfoPtr_meshes;

		// Token: 0x040019CE RID: 6606
		private static readonly IntPtr NativeFieldInfoPtr_meshTransform;

		// Token: 0x040019CF RID: 6607
		private static readonly IntPtr NativeFieldInfoPtr_verts;

		// Token: 0x040019D0 RID: 6608
		private static readonly IntPtr NativeFieldInfoPtr_mesher;

		// Token: 0x040019D1 RID: 6609
		private static readonly IntPtr NativeFieldInfoPtr_vts;

		// Token: 0x040019D2 RID: 6610
		private static readonly IntPtr NativeFieldInfoPtr_vts2;

		// Token: 0x040019D3 RID: 6611
		private static readonly IntPtr NativeFieldInfoPtr_mshVerts;

		// Token: 0x040019D4 RID: 6612
		private static readonly IntPtr NativeFieldInfoPtr_zeroed;

		// Token: 0x040019D5 RID: 6613
		private static readonly IntPtr NativeFieldInfoPtr_defPos;

		// Token: 0x040019D6 RID: 6614
		private static readonly IntPtr NativeFieldInfoPtr_offSets;

		// Token: 0x040019D7 RID: 6615
		private static readonly IntPtr NativeFieldInfoPtr_mesherMesh;

		// Token: 0x040019D8 RID: 6616
		private static readonly IntPtr NativeFieldInfoPtr_mesherIndex;

		// Token: 0x040019D9 RID: 6617
		private static readonly IntPtr NativeFieldInfoPtr_rend;

		// Token: 0x040019DA RID: 6618
		private static readonly IntPtr NativeFieldInfoPtr_off;

		// Token: 0x040019DB RID: 6619
		private static readonly IntPtr NativeFieldInfoPtr_rTechs;

		// Token: 0x040019DC RID: 6620
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040019DD RID: 6621
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040019DE RID: 6622
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040019DF RID: 6623
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040019E0 RID: 6624
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
