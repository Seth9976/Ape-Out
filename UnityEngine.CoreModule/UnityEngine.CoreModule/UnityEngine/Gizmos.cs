using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000059 RID: 89
	public sealed class Gizmos : Object
	{
		// Token: 0x06000526 RID: 1318 RVA: 0x00022AF4 File Offset: 0x00020CF4
		// Note: this type is marked as 'beforefieldinit'.
		static Gizmos()
		{
			Il2CppClassPointerStore<Gizmos>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Gizmos");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Gizmos>.NativeClassPtr);
			Gizmos.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100663732);
			Gizmos.NativeMethodInfoPtr_DrawWireSphere_Public_Static_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100663733);
			Gizmos.NativeMethodInfoPtr_DrawSphere_Public_Static_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100663734);
			Gizmos.NativeMethodInfoPtr_DrawWireCube_Public_Static_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100663735);
			Gizmos.NativeMethodInfoPtr_DrawCube_Public_Static_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100663736);
			Gizmos.NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Int32_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100663737);
			Gizmos.NativeMethodInfoPtr_DrawWireMesh_Public_Static_Void_Mesh_Int32_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100663738);
			Gizmos.NativeMethodInfoPtr_set_color_Public_Static_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100663739);
			Gizmos.NativeMethodInfoPtr_set_matrix_Public_Static_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100663740);
			Gizmos.NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100663741);
			Gizmos.NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100663742);
			Gizmos.NativeMethodInfoPtr_DrawWireMesh_Public_Static_Void_Mesh_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100663743);
			Gizmos.NativeMethodInfoPtr_DrawLine_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100663744);
			Gizmos.NativeMethodInfoPtr_DrawWireSphere_Injected_Private_Static_Void_byref_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100663745);
			Gizmos.NativeMethodInfoPtr_DrawSphere_Injected_Private_Static_Void_byref_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100663746);
			Gizmos.NativeMethodInfoPtr_DrawWireCube_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100663747);
			Gizmos.NativeMethodInfoPtr_DrawCube_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100663748);
			Gizmos.NativeMethodInfoPtr_DrawMesh_Injected_Private_Static_Void_Mesh_Int32_byref_Vector3_byref_Quaternion_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100663749);
			Gizmos.NativeMethodInfoPtr_DrawWireMesh_Injected_Private_Static_Void_Mesh_Int32_byref_Vector3_byref_Quaternion_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100663750);
			Gizmos.NativeMethodInfoPtr_set_color_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100663751);
			Gizmos.NativeMethodInfoPtr_set_matrix_Injected_Private_Static_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100663752);
			Gizmos.get_exposureDelegateField = IL2CPP.ResolveICall<Gizmos.get_exposureDelegate>("UnityEngine.Gizmos::get_exposure");
			Gizmos.set_exposureDelegateField = IL2CPP.ResolveICall<Gizmos.set_exposureDelegate>("UnityEngine.Gizmos::set_exposure");
			Gizmos.get_probeSizeDelegateField = IL2CPP.ResolveICall<Gizmos.get_probeSizeDelegate>("UnityEngine.Gizmos::get_probeSize");
			Gizmos.DrawIcon_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.DrawIcon_InjectedDelegate>("UnityEngine.Gizmos::DrawIcon_Injected");
			Gizmos.DrawGUITexture_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.DrawGUITexture_InjectedDelegate>("UnityEngine.Gizmos::DrawGUITexture_Injected");
			Gizmos.get_color_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.get_color_InjectedDelegate>("UnityEngine.Gizmos::get_color_Injected");
			Gizmos.get_matrix_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.get_matrix_InjectedDelegate>("UnityEngine.Gizmos::get_matrix_Injected");
			Gizmos.DrawFrustum_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.DrawFrustum_InjectedDelegate>("UnityEngine.Gizmos::DrawFrustum_Injected");
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00022D40 File Offset: 0x00020F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487666, XrefRangeEnd = 487668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLine(Vector3 from, Vector3 to)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00022D80 File Offset: 0x00020F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487668, XrefRangeEnd = 487670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawWireSphere(Vector3 center, float radius)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref center;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawWireSphere_Public_Static_Void_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00022DC0 File Offset: 0x00020FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487670, XrefRangeEnd = 487672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawSphere(Vector3 center, float radius)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref center;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawSphere_Public_Static_Void_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00022E00 File Offset: 0x00021000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487672, XrefRangeEnd = 487674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawWireCube(Vector3 center, Vector3 size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref center;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawWireCube_Public_Static_Void_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00022E40 File Offset: 0x00021040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487674, XrefRangeEnd = 487676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawCube(Vector3 center, Vector3 size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref center;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawCube_Public_Static_Void_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00022E80 File Offset: 0x00021080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487676, XrefRangeEnd = 487678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submeshIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Int32_Vector3_Quaternion_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00022EF0 File Offset: 0x000210F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487678, XrefRangeEnd = 487680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submeshIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawWireMesh_Public_Static_Void_Mesh_Int32_Vector3_Quaternion_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000540 RID: 1344 RVA: 0x00023348 File Offset: 0x00021548
		// (set) Token: 0x0600052E RID: 1326 RVA: 0x00022F60 File Offset: 0x00021160
		public unsafe static Color color
		{
			get
			{
				Color color;
				Gizmos.get_color_Injected(out color);
				return color;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487680, XrefRangeEnd = 487682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_set_color_Public_Static_set_Void_Color_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x00023360 File Offset: 0x00021560
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x00022F94 File Offset: 0x00021194
		public unsafe static Matrix4x4 matrix
		{
			get
			{
				Matrix4x4 matrix4x;
				Gizmos.get_matrix_Injected(out matrix4x);
				return matrix4x;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487682, XrefRangeEnd = 487684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_set_matrix_Public_Static_set_Void_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00022FC8 File Offset: 0x000211C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 487692, RefRangeEnd = 487693, XrefRangeStart = 487684, XrefRangeEnd = 487692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawMesh(Mesh mesh)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00023000 File Offset: 0x00021200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487693, XrefRangeEnd = 487695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Vector3_Quaternion_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00023060 File Offset: 0x00021260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487695, XrefRangeEnd = 487697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawWireMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawWireMesh_Public_Static_Void_Mesh_Vector3_Quaternion_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x000230C0 File Offset: 0x000212C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487697, XrefRangeEnd = 487701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLine_Injected(ref Vector3 from, ref Vector3 to)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &to;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawLine_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00023100 File Offset: 0x00021300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487701, XrefRangeEnd = 487705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawWireSphere_Injected(ref Vector3 center, float radius)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &center;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawWireSphere_Injected_Private_Static_Void_byref_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00023140 File Offset: 0x00021340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487705, XrefRangeEnd = 487709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawSphere_Injected(ref Vector3 center, float radius)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &center;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawSphere_Injected_Private_Static_Void_byref_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00023180 File Offset: 0x00021380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487709, XrefRangeEnd = 487713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawWireCube_Injected(ref Vector3 center, ref Vector3 size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &center;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawWireCube_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x000231C0 File Offset: 0x000213C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487713, XrefRangeEnd = 487717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawCube_Injected(ref Vector3 center, ref Vector3 size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &center;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawCube_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00023200 File Offset: 0x00021400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487717, XrefRangeEnd = 487721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawMesh_Injected(Mesh mesh, int submeshIndex, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submeshIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawMesh_Injected_Private_Static_Void_Mesh_Int32_byref_Vector3_byref_Quaternion_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00023270 File Offset: 0x00021470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487721, XrefRangeEnd = 487725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawWireMesh_Injected(Mesh mesh, int submeshIndex, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submeshIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawWireMesh_Injected_Private_Static_Void_Mesh_Int32_byref_Vector3_byref_Quaternion_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x000232E0 File Offset: 0x000214E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487725, XrefRangeEnd = 487729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void set_color_Injected(ref Color value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_set_color_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00023314 File Offset: 0x00021514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487729, XrefRangeEnd = 487733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void set_matrix_Injected(ref Matrix4x4 value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_set_matrix_Injected_Private_Static_Void_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00004ABF File Offset: 0x00002CBF
		public Gizmos(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00004AC8 File Offset: 0x00002CC8
		public static void DrawIcon(Vector3 center, string name, bool allowScaling)
		{
			Gizmos.DrawIcon(center, name, allowScaling, Color.white);
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00004AD9 File Offset: 0x00002CD9
		public static void DrawIcon(Vector3 center, string name, bool allowScaling, Color tint)
		{
			Gizmos.DrawIcon_Injected(ref center, name, allowScaling, ref tint);
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00004AE6 File Offset: 0x00002CE6
		public static void DrawGUITexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat)
		{
			Gizmos.DrawGUITexture_Injected(ref screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, mat);
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x00023378 File Offset: 0x00021578
		// (set) Token: 0x06000543 RID: 1347 RVA: 0x00004AF8 File Offset: 0x00002CF8
		public static Texture exposure
		{
			get
			{
				IntPtr intPtr = Gizmos.get_exposureDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				Gizmos.set_exposureDelegateField(IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x00004B0A File Offset: 0x00002D0A
		public static float probeSize
		{
			get
			{
				return Gizmos.get_probeSizeDelegateField();
			}
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00004B16 File Offset: 0x00002D16
		public static void DrawFrustum(Vector3 center, float fov, float maxRange, float minRange, float aspect)
		{
			Gizmos.DrawFrustum_Injected(ref center, fov, maxRange, minRange, aspect);
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00004B24 File Offset: 0x00002D24
		public static void DrawRay(Ray r)
		{
			Gizmos.DrawLine(r.origin, r.origin + r.direction);
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00004B47 File Offset: 0x00002D47
		public static void DrawRay(Vector3 from, Vector3 direction)
		{
			Gizmos.DrawLine(from, from + direction);
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x000233A0 File Offset: 0x000215A0
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation)
		{
			Vector3 one = Vector3.one;
			Gizmos.DrawMesh(mesh, position, rotation, one);
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x000233C0 File Offset: 0x000215C0
		public static void DrawMesh(Mesh mesh, Vector3 position)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Gizmos.DrawMesh(mesh, position, identity, one);
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x000233E4 File Offset: 0x000215E4
		public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation)
		{
			Vector3 one = Vector3.one;
			Gizmos.DrawMesh(mesh, submeshIndex, position, rotation, one);
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00023404 File Offset: 0x00021604
		public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Gizmos.DrawMesh(mesh, submeshIndex, position, identity, one);
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x0002342C File Offset: 0x0002162C
		public static void DrawMesh(Mesh mesh, int submeshIndex)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Vector3 zero = Vector3.zero;
			Gizmos.DrawMesh(mesh, submeshIndex, zero, identity, one);
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00023458 File Offset: 0x00021658
		public static void DrawWireMesh(Mesh mesh, Vector3 position, Quaternion rotation)
		{
			Vector3 one = Vector3.one;
			Gizmos.DrawWireMesh(mesh, position, rotation, one);
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00023478 File Offset: 0x00021678
		public static void DrawWireMesh(Mesh mesh, Vector3 position)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Gizmos.DrawWireMesh(mesh, position, identity, one);
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x0002349C File Offset: 0x0002169C
		public static void DrawWireMesh(Mesh mesh)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Vector3 zero = Vector3.zero;
			Gizmos.DrawWireMesh(mesh, zero, identity, one);
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x000234C8 File Offset: 0x000216C8
		public static void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation)
		{
			Vector3 one = Vector3.one;
			Gizmos.DrawWireMesh(mesh, submeshIndex, position, rotation, one);
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x000234E8 File Offset: 0x000216E8
		public static void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Gizmos.DrawWireMesh(mesh, submeshIndex, position, identity, one);
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00023510 File Offset: 0x00021710
		public static void DrawWireMesh(Mesh mesh, int submeshIndex)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Vector3 zero = Vector3.zero;
			Gizmos.DrawWireMesh(mesh, submeshIndex, zero, identity, one);
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0002353C File Offset: 0x0002173C
		public static void DrawIcon(Vector3 center, string name)
		{
			bool flag = true;
			Gizmos.DrawIcon(center, name, flag);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00023558 File Offset: 0x00021758
		public static void DrawGUITexture(Rect screenRect, Texture texture)
		{
			Material material = null;
			Gizmos.DrawGUITexture(screenRect, texture, material);
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00004B58 File Offset: 0x00002D58
		public static void DrawGUITexture(Rect screenRect, Texture texture, Material mat)
		{
			Gizmos.DrawGUITexture(screenRect, texture, 0, 0, 0, 0, mat);
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00023574 File Offset: 0x00021774
		public static void DrawGUITexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder)
		{
			Material material = null;
			Gizmos.DrawGUITexture(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, material);
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00004B68 File Offset: 0x00002D68
		public static void DrawIcon_Injected(ref Vector3 center, string name, bool allowScaling, ref Color tint)
		{
			Gizmos.DrawIcon_InjectedDelegateField(ref center, IL2CPP.ManagedStringToIl2Cpp(name), allowScaling, ref tint);
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00004B7D File Offset: 0x00002D7D
		public static void DrawGUITexture_Injected(ref Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat)
		{
			Gizmos.DrawGUITexture_InjectedDelegateField(ref screenRect, IL2CPP.Il2CppObjectBaseToPtr(texture), leftBorder, rightBorder, topBorder, bottomBorder, IL2CPP.Il2CppObjectBaseToPtr(mat));
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00004B9D File Offset: 0x00002D9D
		public static void get_color_Injected(out Color ret)
		{
			Gizmos.get_color_InjectedDelegateField(out ret);
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00004BAA File Offset: 0x00002DAA
		public static void get_matrix_Injected(out Matrix4x4 ret)
		{
			Gizmos.get_matrix_InjectedDelegateField(out ret);
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00004BB7 File Offset: 0x00002DB7
		public static void DrawFrustum_Injected(ref Vector3 center, float fov, float maxRange, float minRange, float aspect)
		{
			Gizmos.DrawFrustum_InjectedDelegateField(ref center, fov, maxRange, minRange, aspect);
		}

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_0;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeMethodInfoPtr_DrawWireSphere_Public_Static_Void_Vector3_Single_0;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeMethodInfoPtr_DrawSphere_Public_Static_Void_Vector3_Single_0;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeMethodInfoPtr_DrawWireCube_Public_Static_Void_Vector3_Vector3_0;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeMethodInfoPtr_DrawCube_Public_Static_Void_Vector3_Vector3_0;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Int32_Vector3_Quaternion_Vector3_0;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeMethodInfoPtr_DrawWireMesh_Public_Static_Void_Mesh_Int32_Vector3_Quaternion_Vector3_0;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Public_Static_set_Void_Color_0;

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeMethodInfoPtr_set_matrix_Public_Static_set_Void_Matrix4x4_0;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_0;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Vector3_Quaternion_Vector3_0;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeMethodInfoPtr_DrawWireMesh_Public_Static_Void_Mesh_Vector3_Quaternion_Vector3_0;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeMethodInfoPtr_DrawLine_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeMethodInfoPtr_DrawWireSphere_Injected_Private_Static_Void_byref_Vector3_Single_0;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeMethodInfoPtr_DrawSphere_Injected_Private_Static_Void_byref_Vector3_Single_0;

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeMethodInfoPtr_DrawWireCube_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeMethodInfoPtr_DrawCube_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeMethodInfoPtr_DrawMesh_Injected_Private_Static_Void_Mesh_Int32_byref_Vector3_byref_Quaternion_byref_Vector3_0;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeMethodInfoPtr_DrawWireMesh_Injected_Private_Static_Void_Mesh_Int32_byref_Vector3_byref_Quaternion_byref_Vector3_0;

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeMethodInfoPtr_set_matrix_Injected_Private_Static_Void_byref_Matrix4x4_0;

		// Token: 0x04000401 RID: 1025
		private static readonly Gizmos.get_exposureDelegate get_exposureDelegateField;

		// Token: 0x04000402 RID: 1026
		private static readonly Gizmos.set_exposureDelegate set_exposureDelegateField;

		// Token: 0x04000403 RID: 1027
		private static readonly Gizmos.get_probeSizeDelegate get_probeSizeDelegateField;

		// Token: 0x04000404 RID: 1028
		private static readonly Gizmos.DrawIcon_InjectedDelegate DrawIcon_InjectedDelegateField;

		// Token: 0x04000405 RID: 1029
		private static readonly Gizmos.DrawGUITexture_InjectedDelegate DrawGUITexture_InjectedDelegateField;

		// Token: 0x04000406 RID: 1030
		private static readonly Gizmos.get_color_InjectedDelegate get_color_InjectedDelegateField;

		// Token: 0x04000407 RID: 1031
		private static readonly Gizmos.get_matrix_InjectedDelegate get_matrix_InjectedDelegateField;

		// Token: 0x04000408 RID: 1032
		private static readonly Gizmos.DrawFrustum_InjectedDelegate DrawFrustum_InjectedDelegateField;

		// Token: 0x02000428 RID: 1064
		// (Invoke) Token: 0x0600267A RID: 9850
		private delegate IntPtr get_exposureDelegate();

		// Token: 0x02000429 RID: 1065
		// (Invoke) Token: 0x0600267C RID: 9852
		private delegate void set_exposureDelegate(IntPtr value);

		// Token: 0x0200042A RID: 1066
		// (Invoke) Token: 0x0600267E RID: 9854
		private delegate float get_probeSizeDelegate();

		// Token: 0x0200042B RID: 1067
		// (Invoke) Token: 0x06002680 RID: 9856
		private delegate void DrawIcon_InjectedDelegate(IntPtr center, IntPtr name, bool allowScaling, IntPtr tint);

		// Token: 0x0200042C RID: 1068
		// (Invoke) Token: 0x06002682 RID: 9858
		private delegate void DrawGUITexture_InjectedDelegate(IntPtr screenRect, IntPtr texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, IntPtr mat);

		// Token: 0x0200042D RID: 1069
		// (Invoke) Token: 0x06002684 RID: 9860
		private delegate void get_color_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x0200042E RID: 1070
		// (Invoke) Token: 0x06002686 RID: 9862
		private delegate void get_matrix_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x0200042F RID: 1071
		// (Invoke) Token: 0x06002688 RID: 9864
		private delegate void DrawFrustum_InjectedDelegate(IntPtr center, float fov, float maxRange, float minRange, float aspect);
	}
}
