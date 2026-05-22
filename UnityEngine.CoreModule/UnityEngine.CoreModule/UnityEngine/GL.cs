using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000062 RID: 98
	public sealed class GL : Object
	{
		// Token: 0x06000697 RID: 1687 RVA: 0x00026770 File Offset: 0x00024970
		// Note: this type is marked as 'beforefieldinit'.
		static GL()
		{
			Il2CppClassPointerStore<GL>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "GL");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GL>.NativeClassPtr);
			GL.NativeMethodInfoPtr_GetGPUProjectionMatrix_Public_Static_Matrix4x4_Matrix4x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100663814);
			GL.NativeMethodInfoPtr_GLClear_Private_Static_Void_Boolean_Boolean_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100663815);
			GL.NativeMethodInfoPtr_Clear_Public_Static_Void_Boolean_Boolean_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100663816);
			GL.NativeMethodInfoPtr_GetGPUProjectionMatrix_Injected_Private_Static_Void_byref_Matrix4x4_Boolean_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100663817);
			GL.NativeMethodInfoPtr_GLClear_Injected_Private_Static_Void_Boolean_Boolean_byref_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100663818);
			GL.Vertex3DelegateField = IL2CPP.ResolveICall<GL.Vertex3Delegate>("UnityEngine.GL::Vertex3");
			GL.VerticesDelegateField = IL2CPP.ResolveICall<GL.VerticesDelegate>("UnityEngine.GL::Vertices");
			GL.TexCoord3DelegateField = IL2CPP.ResolveICall<GL.TexCoord3Delegate>("UnityEngine.GL::TexCoord3");
			GL.MultiTexCoord3DelegateField = IL2CPP.ResolveICall<GL.MultiTexCoord3Delegate>("UnityEngine.GL::MultiTexCoord3");
			GL.ImmediateColorDelegateField = IL2CPP.ResolveICall<GL.ImmediateColorDelegate>("UnityEngine.GL::ImmediateColor");
			GL.get_wireframeDelegateField = IL2CPP.ResolveICall<GL.get_wireframeDelegate>("UnityEngine.GL::get_wireframe");
			GL.set_wireframeDelegateField = IL2CPP.ResolveICall<GL.set_wireframeDelegate>("UnityEngine.GL::set_wireframe");
			GL.get_sRGBWriteDelegateField = IL2CPP.ResolveICall<GL.get_sRGBWriteDelegate>("UnityEngine.GL::get_sRGBWrite");
			GL.set_sRGBWriteDelegateField = IL2CPP.ResolveICall<GL.set_sRGBWriteDelegate>("UnityEngine.GL::set_sRGBWrite");
			GL.get_invertCullingDelegateField = IL2CPP.ResolveICall<GL.get_invertCullingDelegate>("UnityEngine.GL::get_invertCulling");
			GL.set_invertCullingDelegateField = IL2CPP.ResolveICall<GL.set_invertCullingDelegate>("UnityEngine.GL::set_invertCulling");
			GL.FlushDelegateField = IL2CPP.ResolveICall<GL.FlushDelegate>("UnityEngine.GL::Flush");
			GL.RenderTargetBarrierDelegateField = IL2CPP.ResolveICall<GL.RenderTargetBarrierDelegate>("UnityEngine.GL::RenderTargetBarrier");
			GL.IssuePluginEventDelegateField = IL2CPP.ResolveICall<GL.IssuePluginEventDelegate>("UnityEngine.GL::IssuePluginEvent");
			GL.SetRevertBackfacingDelegateField = IL2CPP.ResolveICall<GL.SetRevertBackfacingDelegate>("UnityEngine.GL::SetRevertBackfacing");
			GL.PushMatrixDelegateField = IL2CPP.ResolveICall<GL.PushMatrixDelegate>("UnityEngine.GL::PushMatrix");
			GL.PopMatrixDelegateField = IL2CPP.ResolveICall<GL.PopMatrixDelegate>("UnityEngine.GL::PopMatrix");
			GL.LoadIdentityDelegateField = IL2CPP.ResolveICall<GL.LoadIdentityDelegate>("UnityEngine.GL::LoadIdentity");
			GL.LoadOrthoDelegateField = IL2CPP.ResolveICall<GL.LoadOrthoDelegate>("UnityEngine.GL::LoadOrtho");
			GL.LoadPixelMatrixDelegateField = IL2CPP.ResolveICall<GL.LoadPixelMatrixDelegate>("UnityEngine.GL::LoadPixelMatrix");
			GL.InvalidateStateDelegateField = IL2CPP.ResolveICall<GL.InvalidateStateDelegate>("UnityEngine.GL::InvalidateState");
			GL.GLLoadPixelMatrixScriptDelegateField = IL2CPP.ResolveICall<GL.GLLoadPixelMatrixScriptDelegate>("UnityEngine.GL::GLLoadPixelMatrixScript");
			GL.GLIssuePluginEventDelegateField = IL2CPP.ResolveICall<GL.GLIssuePluginEventDelegate>("UnityEngine.GL::GLIssuePluginEvent");
			GL.BeginDelegateField = IL2CPP.ResolveICall<GL.BeginDelegate>("UnityEngine.GL::Begin");
			GL.EndDelegateField = IL2CPP.ResolveICall<GL.EndDelegate>("UnityEngine.GL::End");
			GL.ClearWithSkyboxDelegateField = IL2CPP.ResolveICall<GL.ClearWithSkyboxDelegate>("UnityEngine.GL::ClearWithSkybox");
			GL.GetWorldViewMatrix_InjectedDelegateField = IL2CPP.ResolveICall<GL.GetWorldViewMatrix_InjectedDelegate>("UnityEngine.GL::GetWorldViewMatrix_Injected");
			GL.SetViewMatrix_InjectedDelegateField = IL2CPP.ResolveICall<GL.SetViewMatrix_InjectedDelegate>("UnityEngine.GL::SetViewMatrix_Injected");
			GL.MultMatrix_InjectedDelegateField = IL2CPP.ResolveICall<GL.MultMatrix_InjectedDelegate>("UnityEngine.GL::MultMatrix_Injected");
			GL.LoadProjectionMatrix_InjectedDelegateField = IL2CPP.ResolveICall<GL.LoadProjectionMatrix_InjectedDelegate>("UnityEngine.GL::LoadProjectionMatrix_Injected");
			GL.Viewport_InjectedDelegateField = IL2CPP.ResolveICall<GL.Viewport_InjectedDelegate>("UnityEngine.GL::Viewport_Injected");
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x000269D8 File Offset: 0x00024BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488089, XrefRangeEnd = 488091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, bool renderIntoTexture)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref proj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderIntoTexture;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_GetGPUProjectionMatrix_Public_Static_Matrix4x4_Matrix4x4_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00026A24 File Offset: 0x00024C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488091, XrefRangeEnd = 488093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GLClear(bool clearDepth, bool clearColor, Color backgroundColor, float depth)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clearDepth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref backgroundColor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_GLClear_Private_Static_Void_Boolean_Boolean_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00026A80 File Offset: 0x00024C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488093, XrefRangeEnd = 488095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Clear(bool clearDepth, bool clearColor, Color backgroundColor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clearDepth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref backgroundColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_Clear_Public_Static_Void_Boolean_Boolean_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00026AD0 File Offset: 0x00024CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488095, XrefRangeEnd = 488099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetGPUProjectionMatrix_Injected(ref Matrix4x4 proj, bool renderIntoTexture, out Matrix4x4 ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &proj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderIntoTexture;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_GetGPUProjectionMatrix_Injected_Private_Static_Void_byref_Matrix4x4_Boolean_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00026B20 File Offset: 0x00024D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488099, XrefRangeEnd = 488103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GLClear_Injected(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clearDepth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &backgroundColor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_GLClear_Injected_Private_Static_Void_Boolean_Boolean_byref_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00005404 File Offset: 0x00003604
		public GL(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0000540D File Offset: 0x0000360D
		public static void Vertex3(float x, float y, float z)
		{
			GL.Vertex3DelegateField(x, y, z);
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x0000541C File Offset: 0x0000361C
		public static void Vertex(Vector3 v)
		{
			GL.Vertex3(v.x, v.y, v.z);
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x00005437 File Offset: 0x00003637
		public unsafe static void Vertices(Vector3* v, Vector3* coords, Vector4* colors, int length)
		{
			GL.VerticesDelegateField(v, coords, colors, length);
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00005447 File Offset: 0x00003647
		public static void TexCoord3(float x, float y, float z)
		{
			GL.TexCoord3DelegateField(x, y, z);
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00005456 File Offset: 0x00003656
		public static void TexCoord(Vector3 v)
		{
			GL.TexCoord3(v.x, v.y, v.z);
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00005471 File Offset: 0x00003671
		public static void TexCoord2(float x, float y)
		{
			GL.TexCoord3(x, y, 0f);
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00005481 File Offset: 0x00003681
		public static void MultiTexCoord3(int unit, float x, float y, float z)
		{
			GL.MultiTexCoord3DelegateField(unit, x, y, z);
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00005491 File Offset: 0x00003691
		public static void MultiTexCoord(int unit, Vector3 v)
		{
			GL.MultiTexCoord3(unit, v.x, v.y, v.z);
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x000054AD File Offset: 0x000036AD
		public static void MultiTexCoord2(int unit, float x, float y)
		{
			GL.MultiTexCoord3(unit, x, y, 0f);
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x000054BE File Offset: 0x000036BE
		public static void ImmediateColor(float r, float g, float b, float a)
		{
			GL.ImmediateColorDelegateField(r, g, b, a);
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x000054CE File Offset: 0x000036CE
		public static void Color(Color c)
		{
			GL.ImmediateColor(c.r, c.g, c.b, c.a);
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x000054EF File Offset: 0x000036EF
		// (set) Token: 0x060006AA RID: 1706 RVA: 0x000054FB File Offset: 0x000036FB
		public static bool wireframe
		{
			get
			{
				return GL.get_wireframeDelegateField();
			}
			set
			{
				GL.set_wireframeDelegateField(value);
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x00005508 File Offset: 0x00003708
		// (set) Token: 0x060006AC RID: 1708 RVA: 0x00005514 File Offset: 0x00003714
		public static bool sRGBWrite
		{
			get
			{
				return GL.get_sRGBWriteDelegateField();
			}
			set
			{
				GL.set_sRGBWriteDelegateField(value);
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x00005521 File Offset: 0x00003721
		// (set) Token: 0x060006AE RID: 1710 RVA: 0x0000552D File Offset: 0x0000372D
		public static bool invertCulling
		{
			get
			{
				return GL.get_invertCullingDelegateField();
			}
			set
			{
				GL.set_invertCullingDelegateField(value);
			}
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x0000553A File Offset: 0x0000373A
		public static void Flush()
		{
			GL.FlushDelegateField();
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00005546 File Offset: 0x00003746
		public static void RenderTargetBarrier()
		{
			GL.RenderTargetBarrierDelegateField();
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00026B7C File Offset: 0x00024D7C
		public static Matrix4x4 GetWorldViewMatrix()
		{
			Matrix4x4 matrix4x;
			GL.GetWorldViewMatrix_Injected(out matrix4x);
			return matrix4x;
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00005552 File Offset: 0x00003752
		public static void SetViewMatrix(Matrix4x4 m)
		{
			GL.SetViewMatrix_Injected(ref m);
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x00026B94 File Offset: 0x00024D94
		// (set) Token: 0x060006B4 RID: 1716 RVA: 0x0000555B File Offset: 0x0000375B
		public static Matrix4x4 modelview
		{
			get
			{
				return GL.GetWorldViewMatrix();
			}
			set
			{
				GL.SetViewMatrix(value);
			}
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x00005565 File Offset: 0x00003765
		public static void MultMatrix(Matrix4x4 m)
		{
			GL.MultMatrix_Injected(ref m);
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x0000556E File Offset: 0x0000376E
		public static void IssuePluginEvent(int eventID)
		{
			GL.IssuePluginEventDelegateField(eventID);
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x0000557B File Offset: 0x0000377B
		public static void SetRevertBackfacing(bool revertBackFaces)
		{
			GL.SetRevertBackfacingDelegateField(revertBackFaces);
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00005588 File Offset: 0x00003788
		public static void PushMatrix()
		{
			GL.PushMatrixDelegateField();
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00005594 File Offset: 0x00003794
		public static void PopMatrix()
		{
			GL.PopMatrixDelegateField();
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x000055A0 File Offset: 0x000037A0
		public static void LoadIdentity()
		{
			GL.LoadIdentityDelegateField();
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x000055AC File Offset: 0x000037AC
		public static void LoadOrtho()
		{
			GL.LoadOrthoDelegateField();
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x000055B8 File Offset: 0x000037B8
		public static void LoadPixelMatrix()
		{
			GL.LoadPixelMatrixDelegateField();
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x000055C4 File Offset: 0x000037C4
		public static void LoadProjectionMatrix(Matrix4x4 mat)
		{
			GL.LoadProjectionMatrix_Injected(ref mat);
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x000055CD File Offset: 0x000037CD
		public static void InvalidateState()
		{
			GL.InvalidateStateDelegateField();
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x000055D9 File Offset: 0x000037D9
		public static void GLLoadPixelMatrixScript(float left, float right, float bottom, float top)
		{
			GL.GLLoadPixelMatrixScriptDelegateField(left, right, bottom, top);
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x000055E9 File Offset: 0x000037E9
		public static void LoadPixelMatrix(float left, float right, float bottom, float top)
		{
			GL.GLLoadPixelMatrixScript(left, right, bottom, top);
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x000055F6 File Offset: 0x000037F6
		public static void GLIssuePluginEvent(IntPtr callback, int eventID)
		{
			GL.GLIssuePluginEventDelegateField(callback, eventID);
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00026BAC File Offset: 0x00024DAC
		public static void IssuePluginEvent(IntPtr callback, int eventID)
		{
			bool flag = callback == IntPtr.Zero;
			if (flag)
			{
				throw new ArgumentException("Null callback specified.", "callback");
			}
			GL.GLIssuePluginEvent(callback, eventID);
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00005604 File Offset: 0x00003804
		public static void Begin(int mode)
		{
			GL.BeginDelegateField(mode);
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00005611 File Offset: 0x00003811
		public static void End()
		{
			GL.EndDelegateField();
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x0000561D File Offset: 0x0000381D
		public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor, float depth)
		{
			GL.GLClear(clearDepth, clearColor, backgroundColor, depth);
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x0000562A File Offset: 0x0000382A
		public static void Viewport(Rect pixelRect)
		{
			GL.Viewport_Injected(ref pixelRect);
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00005633 File Offset: 0x00003833
		public static void ClearWithSkybox(bool clearDepth, Camera camera)
		{
			GL.ClearWithSkyboxDelegateField(clearDepth, IL2CPP.Il2CppObjectBaseToPtr(camera));
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x00005646 File Offset: 0x00003846
		public static void GetWorldViewMatrix_Injected(out Matrix4x4 ret)
		{
			GL.GetWorldViewMatrix_InjectedDelegateField(out ret);
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00005653 File Offset: 0x00003853
		public static void SetViewMatrix_Injected(ref Matrix4x4 m)
		{
			GL.SetViewMatrix_InjectedDelegateField(ref m);
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00005660 File Offset: 0x00003860
		public static void MultMatrix_Injected(ref Matrix4x4 m)
		{
			GL.MultMatrix_InjectedDelegateField(ref m);
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x0000566D File Offset: 0x0000386D
		public static void LoadProjectionMatrix_Injected(ref Matrix4x4 mat)
		{
			GL.LoadProjectionMatrix_InjectedDelegateField(ref mat);
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x0000567A File Offset: 0x0000387A
		public static void Viewport_Injected(ref Rect pixelRect)
		{
			GL.Viewport_InjectedDelegateField(ref pixelRect);
		}

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeMethodInfoPtr_GetGPUProjectionMatrix_Public_Static_Matrix4x4_Matrix4x4_Boolean_0;

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeMethodInfoPtr_GLClear_Private_Static_Void_Boolean_Boolean_Color_Single_0;

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_Boolean_Boolean_Color_0;

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeMethodInfoPtr_GetGPUProjectionMatrix_Injected_Private_Static_Void_byref_Matrix4x4_Boolean_byref_Matrix4x4_0;

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeMethodInfoPtr_GLClear_Injected_Private_Static_Void_Boolean_Boolean_byref_Color_Single_0;

		// Token: 0x0400049A RID: 1178
		public const int TRIANGLES = 4;

		// Token: 0x0400049B RID: 1179
		public const int TRIANGLE_STRIP = 5;

		// Token: 0x0400049C RID: 1180
		public const int QUADS = 7;

		// Token: 0x0400049D RID: 1181
		public const int LINES = 1;

		// Token: 0x0400049E RID: 1182
		public const int LINE_STRIP = 2;

		// Token: 0x0400049F RID: 1183
		private static readonly GL.Vertex3Delegate Vertex3DelegateField;

		// Token: 0x040004A0 RID: 1184
		private static readonly GL.VerticesDelegate VerticesDelegateField;

		// Token: 0x040004A1 RID: 1185
		private static readonly GL.TexCoord3Delegate TexCoord3DelegateField;

		// Token: 0x040004A2 RID: 1186
		private static readonly GL.MultiTexCoord3Delegate MultiTexCoord3DelegateField;

		// Token: 0x040004A3 RID: 1187
		private static readonly GL.ImmediateColorDelegate ImmediateColorDelegateField;

		// Token: 0x040004A4 RID: 1188
		private static readonly GL.get_wireframeDelegate get_wireframeDelegateField;

		// Token: 0x040004A5 RID: 1189
		private static readonly GL.set_wireframeDelegate set_wireframeDelegateField;

		// Token: 0x040004A6 RID: 1190
		private static readonly GL.get_sRGBWriteDelegate get_sRGBWriteDelegateField;

		// Token: 0x040004A7 RID: 1191
		private static readonly GL.set_sRGBWriteDelegate set_sRGBWriteDelegateField;

		// Token: 0x040004A8 RID: 1192
		private static readonly GL.get_invertCullingDelegate get_invertCullingDelegateField;

		// Token: 0x040004A9 RID: 1193
		private static readonly GL.set_invertCullingDelegate set_invertCullingDelegateField;

		// Token: 0x040004AA RID: 1194
		private static readonly GL.FlushDelegate FlushDelegateField;

		// Token: 0x040004AB RID: 1195
		private static readonly GL.RenderTargetBarrierDelegate RenderTargetBarrierDelegateField;

		// Token: 0x040004AC RID: 1196
		private static readonly GL.IssuePluginEventDelegate IssuePluginEventDelegateField;

		// Token: 0x040004AD RID: 1197
		private static readonly GL.SetRevertBackfacingDelegate SetRevertBackfacingDelegateField;

		// Token: 0x040004AE RID: 1198
		private static readonly GL.PushMatrixDelegate PushMatrixDelegateField;

		// Token: 0x040004AF RID: 1199
		private static readonly GL.PopMatrixDelegate PopMatrixDelegateField;

		// Token: 0x040004B0 RID: 1200
		private static readonly GL.LoadIdentityDelegate LoadIdentityDelegateField;

		// Token: 0x040004B1 RID: 1201
		private static readonly GL.LoadOrthoDelegate LoadOrthoDelegateField;

		// Token: 0x040004B2 RID: 1202
		private static readonly GL.LoadPixelMatrixDelegate LoadPixelMatrixDelegateField;

		// Token: 0x040004B3 RID: 1203
		private static readonly GL.InvalidateStateDelegate InvalidateStateDelegateField;

		// Token: 0x040004B4 RID: 1204
		private static readonly GL.GLLoadPixelMatrixScriptDelegate GLLoadPixelMatrixScriptDelegateField;

		// Token: 0x040004B5 RID: 1205
		private static readonly GL.GLIssuePluginEventDelegate GLIssuePluginEventDelegateField;

		// Token: 0x040004B6 RID: 1206
		private static readonly GL.BeginDelegate BeginDelegateField;

		// Token: 0x040004B7 RID: 1207
		private static readonly GL.EndDelegate EndDelegateField;

		// Token: 0x040004B8 RID: 1208
		private static readonly GL.ClearWithSkyboxDelegate ClearWithSkyboxDelegateField;

		// Token: 0x040004B9 RID: 1209
		private static readonly GL.GetWorldViewMatrix_InjectedDelegate GetWorldViewMatrix_InjectedDelegateField;

		// Token: 0x040004BA RID: 1210
		private static readonly GL.SetViewMatrix_InjectedDelegate SetViewMatrix_InjectedDelegateField;

		// Token: 0x040004BB RID: 1211
		private static readonly GL.MultMatrix_InjectedDelegate MultMatrix_InjectedDelegateField;

		// Token: 0x040004BC RID: 1212
		private static readonly GL.LoadProjectionMatrix_InjectedDelegate LoadProjectionMatrix_InjectedDelegateField;

		// Token: 0x040004BD RID: 1213
		private static readonly GL.Viewport_InjectedDelegate Viewport_InjectedDelegateField;

		// Token: 0x02000471 RID: 1137
		// (Invoke) Token: 0x06002718 RID: 10008
		private delegate void Vertex3Delegate(float x, float y, float z);

		// Token: 0x02000472 RID: 1138
		// (Invoke) Token: 0x0600271A RID: 10010
		private delegate void VerticesDelegate(IntPtr v, IntPtr coords, IntPtr colors, int length);

		// Token: 0x02000473 RID: 1139
		// (Invoke) Token: 0x0600271C RID: 10012
		private delegate void TexCoord3Delegate(float x, float y, float z);

		// Token: 0x02000474 RID: 1140
		// (Invoke) Token: 0x0600271E RID: 10014
		private delegate void MultiTexCoord3Delegate(int unit, float x, float y, float z);

		// Token: 0x02000475 RID: 1141
		// (Invoke) Token: 0x06002720 RID: 10016
		private delegate void ImmediateColorDelegate(float r, float g, float b, float a);

		// Token: 0x02000476 RID: 1142
		// (Invoke) Token: 0x06002722 RID: 10018
		private delegate bool get_wireframeDelegate();

		// Token: 0x02000477 RID: 1143
		// (Invoke) Token: 0x06002724 RID: 10020
		private delegate void set_wireframeDelegate(bool value);

		// Token: 0x02000478 RID: 1144
		// (Invoke) Token: 0x06002726 RID: 10022
		private delegate bool get_sRGBWriteDelegate();

		// Token: 0x02000479 RID: 1145
		// (Invoke) Token: 0x06002728 RID: 10024
		private delegate void set_sRGBWriteDelegate(bool value);

		// Token: 0x0200047A RID: 1146
		// (Invoke) Token: 0x0600272A RID: 10026
		private delegate bool get_invertCullingDelegate();

		// Token: 0x0200047B RID: 1147
		// (Invoke) Token: 0x0600272C RID: 10028
		private delegate void set_invertCullingDelegate(bool value);

		// Token: 0x0200047C RID: 1148
		// (Invoke) Token: 0x0600272E RID: 10030
		private delegate void FlushDelegate();

		// Token: 0x0200047D RID: 1149
		// (Invoke) Token: 0x06002730 RID: 10032
		private delegate void RenderTargetBarrierDelegate();

		// Token: 0x0200047E RID: 1150
		// (Invoke) Token: 0x06002732 RID: 10034
		private delegate void IssuePluginEventDelegate(int eventID);

		// Token: 0x0200047F RID: 1151
		// (Invoke) Token: 0x06002734 RID: 10036
		private delegate void SetRevertBackfacingDelegate(bool revertBackFaces);

		// Token: 0x02000480 RID: 1152
		// (Invoke) Token: 0x06002736 RID: 10038
		private delegate void PushMatrixDelegate();

		// Token: 0x02000481 RID: 1153
		// (Invoke) Token: 0x06002738 RID: 10040
		private delegate void PopMatrixDelegate();

		// Token: 0x02000482 RID: 1154
		// (Invoke) Token: 0x0600273A RID: 10042
		private delegate void LoadIdentityDelegate();

		// Token: 0x02000483 RID: 1155
		// (Invoke) Token: 0x0600273C RID: 10044
		private delegate void LoadOrthoDelegate();

		// Token: 0x02000484 RID: 1156
		// (Invoke) Token: 0x0600273E RID: 10046
		private delegate void LoadPixelMatrixDelegate();

		// Token: 0x02000485 RID: 1157
		// (Invoke) Token: 0x06002740 RID: 10048
		private delegate void InvalidateStateDelegate();

		// Token: 0x02000486 RID: 1158
		// (Invoke) Token: 0x06002742 RID: 10050
		private delegate void GLLoadPixelMatrixScriptDelegate(float left, float right, float bottom, float top);

		// Token: 0x02000487 RID: 1159
		// (Invoke) Token: 0x06002744 RID: 10052
		private delegate void GLIssuePluginEventDelegate(IntPtr callback, int eventID);

		// Token: 0x02000488 RID: 1160
		// (Invoke) Token: 0x06002746 RID: 10054
		private delegate void BeginDelegate(int mode);

		// Token: 0x02000489 RID: 1161
		// (Invoke) Token: 0x06002748 RID: 10056
		private delegate void EndDelegate();

		// Token: 0x0200048A RID: 1162
		// (Invoke) Token: 0x0600274A RID: 10058
		private delegate void ClearWithSkyboxDelegate(bool clearDepth, IntPtr camera);

		// Token: 0x0200048B RID: 1163
		// (Invoke) Token: 0x0600274C RID: 10060
		private delegate void GetWorldViewMatrix_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x0200048C RID: 1164
		// (Invoke) Token: 0x0600274E RID: 10062
		private delegate void SetViewMatrix_InjectedDelegate(IntPtr m);

		// Token: 0x0200048D RID: 1165
		// (Invoke) Token: 0x06002750 RID: 10064
		private delegate void MultMatrix_InjectedDelegate(IntPtr m);

		// Token: 0x0200048E RID: 1166
		// (Invoke) Token: 0x06002752 RID: 10066
		private delegate void LoadProjectionMatrix_InjectedDelegate(IntPtr mat);

		// Token: 0x0200048F RID: 1167
		// (Invoke) Token: 0x06002754 RID: 10068
		private delegate void Viewport_InjectedDelegate(IntPtr pixelRect);
	}
}
