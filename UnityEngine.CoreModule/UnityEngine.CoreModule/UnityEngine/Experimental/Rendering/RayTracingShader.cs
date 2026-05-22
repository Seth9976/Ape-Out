using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x020002DA RID: 730
	public sealed class RayTracingShader : Object
	{
		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06002324 RID: 8996 RVA: 0x00012D52 File Offset: 0x00010F52
		public float maxRecursionDepth
		{
			get
			{
				return RayTracingShader.get_maxRecursionDepthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06002325 RID: 8997 RVA: 0x00012D64 File Offset: 0x00010F64
		public void SetFloat(int nameID, float val)
		{
			RayTracingShader.SetFloatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, val);
		}

		// Token: 0x06002326 RID: 8998 RVA: 0x00012D78 File Offset: 0x00010F78
		public void SetInt(int nameID, int val)
		{
			RayTracingShader.SetIntDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, val);
		}

		// Token: 0x06002327 RID: 8999 RVA: 0x00012D8C File Offset: 0x00010F8C
		public void SetVector(int nameID, Vector4 val)
		{
			this.SetVector_Injected(nameID, ref val);
		}

		// Token: 0x06002328 RID: 9000 RVA: 0x00012D97 File Offset: 0x00010F97
		public void SetMatrix(int nameID, Matrix4x4 val)
		{
			this.SetMatrix_Injected(nameID, ref val);
		}

		// Token: 0x06002329 RID: 9001 RVA: 0x00012DA2 File Offset: 0x00010FA2
		public void SetFloatArray(int nameID, Il2CppStructArray<float> values)
		{
			RayTracingShader.SetFloatArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x0600232A RID: 9002 RVA: 0x00012DBB File Offset: 0x00010FBB
		public void SetIntArray(int nameID, Il2CppStructArray<int> values)
		{
			RayTracingShader.SetIntArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x0600232B RID: 9003 RVA: 0x00012DD4 File Offset: 0x00010FD4
		public void SetVectorArray(int nameID, Il2CppStructArray<Vector4> values)
		{
			RayTracingShader.SetVectorArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x0600232C RID: 9004 RVA: 0x00012DED File Offset: 0x00010FED
		public void SetMatrixArray(int nameID, Il2CppStructArray<Matrix4x4> values)
		{
			RayTracingShader.SetMatrixArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x0600232D RID: 9005 RVA: 0x00012E06 File Offset: 0x00011006
		public void SetTexture(int nameID, Texture texture)
		{
			RayTracingShader.SetTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(texture));
		}

		// Token: 0x0600232E RID: 9006 RVA: 0x00012E1F File Offset: 0x0001101F
		public void SetBuffer(int nameID, ComputeBuffer buffer)
		{
			RayTracingShader.SetBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer));
		}

		// Token: 0x0600232F RID: 9007 RVA: 0x00012E38 File Offset: 0x00011038
		public void SetGraphicsBuffer(int nameID, GraphicsBuffer buffer)
		{
			RayTracingShader.SetGraphicsBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer));
		}

		// Token: 0x06002330 RID: 9008 RVA: 0x00012E51 File Offset: 0x00011051
		public void SetConstantComputeBuffer(int nameID, ComputeBuffer buffer, int offset, int size)
		{
			RayTracingShader.SetConstantComputeBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer), offset, size);
		}

		// Token: 0x06002331 RID: 9009 RVA: 0x00012E6D File Offset: 0x0001106D
		public void SetConstantGraphicsBuffer(int nameID, GraphicsBuffer buffer, int offset, int size)
		{
			RayTracingShader.SetConstantGraphicsBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer), offset, size);
		}

		// Token: 0x06002332 RID: 9010 RVA: 0x00012E89 File Offset: 0x00011089
		public void SetAccelerationStructure(int nameID, RayTracingAccelerationStructure accelerationStructure)
		{
			RayTracingShader.SetAccelerationStructureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(accelerationStructure));
		}

		// Token: 0x06002333 RID: 9011 RVA: 0x00012EA2 File Offset: 0x000110A2
		public void SetShaderPass(string passName)
		{
			RayTracingShader.SetShaderPassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(passName));
		}

		// Token: 0x06002334 RID: 9012 RVA: 0x00012EBA File Offset: 0x000110BA
		public void SetTextureFromGlobal(int nameID, int globalTextureNameID)
		{
			RayTracingShader.SetTextureFromGlobalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, globalTextureNameID);
		}

		// Token: 0x06002335 RID: 9013 RVA: 0x00012ECE File Offset: 0x000110CE
		public void Dispatch(string rayGenFunctionName, int width, int height, int depth, [Optional] Camera camera)
		{
			RayTracingShader.DispatchDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(rayGenFunctionName), width, height, depth, IL2CPP.Il2CppObjectBaseToPtr(camera));
		}

		// Token: 0x06002336 RID: 9014 RVA: 0x00012EF1 File Offset: 0x000110F1
		public void SetBuffer(int nameID, GraphicsBuffer buffer)
		{
			this.SetGraphicsBuffer(nameID, buffer);
		}

		// Token: 0x06002337 RID: 9015 RVA: 0x00012EFD File Offset: 0x000110FD
		public void SetFloat(string name, float val)
		{
			this.SetFloat(Shader.PropertyToID(name), val);
		}

		// Token: 0x06002338 RID: 9016 RVA: 0x00012F0E File Offset: 0x0001110E
		public void SetInt(string name, int val)
		{
			this.SetInt(Shader.PropertyToID(name), val);
		}

		// Token: 0x06002339 RID: 9017 RVA: 0x00012F1F File Offset: 0x0001111F
		public void SetVector(string name, Vector4 val)
		{
			this.SetVector(Shader.PropertyToID(name), val);
		}

		// Token: 0x0600233A RID: 9018 RVA: 0x00012F30 File Offset: 0x00011130
		public void SetMatrix(string name, Matrix4x4 val)
		{
			this.SetMatrix(Shader.PropertyToID(name), val);
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x00012F41 File Offset: 0x00011141
		public void SetVectorArray(string name, Il2CppStructArray<Vector4> values)
		{
			this.SetVectorArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x0600233C RID: 9020 RVA: 0x00012F52 File Offset: 0x00011152
		public void SetMatrixArray(string name, Il2CppStructArray<Matrix4x4> values)
		{
			this.SetMatrixArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x00012F63 File Offset: 0x00011163
		public void SetFloats(string name, Il2CppStructArray<float> values)
		{
			this.SetFloatArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x0600233E RID: 9022 RVA: 0x00012F74 File Offset: 0x00011174
		public void SetFloats(string name, params float[] values)
		{
			this.SetFloats(name, new Il2CppStructArray<float>(values));
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x00012F83 File Offset: 0x00011183
		public void SetFloats(int nameID, Il2CppStructArray<float> values)
		{
			this.SetFloatArray(nameID, values);
		}

		// Token: 0x06002340 RID: 9024 RVA: 0x00012F8F File Offset: 0x0001118F
		public void SetFloats(int nameID, params float[] values)
		{
			this.SetFloats(nameID, new Il2CppStructArray<float>(values));
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x00012F9E File Offset: 0x0001119E
		public void SetInts(string name, Il2CppStructArray<int> values)
		{
			this.SetIntArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06002342 RID: 9026 RVA: 0x00012FAF File Offset: 0x000111AF
		public void SetInts(string name, params int[] values)
		{
			this.SetInts(name, new Il2CppStructArray<int>(values));
		}

		// Token: 0x06002343 RID: 9027 RVA: 0x00012FBE File Offset: 0x000111BE
		public void SetInts(int nameID, Il2CppStructArray<int> values)
		{
			this.SetIntArray(nameID, values);
		}

		// Token: 0x06002344 RID: 9028 RVA: 0x00012FCA File Offset: 0x000111CA
		public void SetInts(int nameID, params int[] values)
		{
			this.SetInts(nameID, new Il2CppStructArray<int>(values));
		}

		// Token: 0x06002345 RID: 9029 RVA: 0x00012FD9 File Offset: 0x000111D9
		public void SetBool(string name, bool val)
		{
			this.SetInt(Shader.PropertyToID(name), val ? 1 : 0);
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x00012FF0 File Offset: 0x000111F0
		public void SetBool(int nameID, bool val)
		{
			this.SetInt(nameID, val ? 1 : 0);
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x00013002 File Offset: 0x00011202
		public void SetTexture(string name, Texture texture)
		{
			this.SetTexture(Shader.PropertyToID(name), texture);
		}

		// Token: 0x06002348 RID: 9032 RVA: 0x00013013 File Offset: 0x00011213
		public void SetBuffer(string name, ComputeBuffer buffer)
		{
			this.SetBuffer(Shader.PropertyToID(name), buffer);
		}

		// Token: 0x06002349 RID: 9033 RVA: 0x00013024 File Offset: 0x00011224
		public void SetBuffer(string name, GraphicsBuffer buffer)
		{
			this.SetBuffer(Shader.PropertyToID(name), buffer);
		}

		// Token: 0x0600234A RID: 9034 RVA: 0x00013035 File Offset: 0x00011235
		public void SetConstantBuffer(int nameID, ComputeBuffer buffer, int offset, int size)
		{
			this.SetConstantComputeBuffer(nameID, buffer, offset, size);
		}

		// Token: 0x0600234B RID: 9035 RVA: 0x00013044 File Offset: 0x00011244
		public void SetConstantBuffer(string name, ComputeBuffer buffer, int offset, int size)
		{
			this.SetConstantComputeBuffer(Shader.PropertyToID(name), buffer, offset, size);
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x00013058 File Offset: 0x00011258
		public void SetConstantBuffer(int nameID, GraphicsBuffer buffer, int offset, int size)
		{
			this.SetConstantGraphicsBuffer(nameID, buffer, offset, size);
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x00013067 File Offset: 0x00011267
		public void SetConstantBuffer(string name, GraphicsBuffer buffer, int offset, int size)
		{
			this.SetConstantGraphicsBuffer(Shader.PropertyToID(name), buffer, offset, size);
		}

		// Token: 0x0600234E RID: 9038 RVA: 0x0001307B File Offset: 0x0001127B
		public void SetAccelerationStructure(string name, RayTracingAccelerationStructure accelerationStructure)
		{
			this.SetAccelerationStructure(Shader.PropertyToID(name), accelerationStructure);
		}

		// Token: 0x0600234F RID: 9039 RVA: 0x0001308C File Offset: 0x0001128C
		public void SetTextureFromGlobal(string name, string globalTextureName)
		{
			this.SetTextureFromGlobal(Shader.PropertyToID(name), Shader.PropertyToID(globalTextureName));
		}

		// Token: 0x06002350 RID: 9040 RVA: 0x000130A2 File Offset: 0x000112A2
		public void SetVector_Injected(int nameID, ref Vector4 val)
		{
			RayTracingShader.SetVector_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, ref val);
		}

		// Token: 0x06002351 RID: 9041 RVA: 0x000130B6 File Offset: 0x000112B6
		public void SetMatrix_Injected(int nameID, ref Matrix4x4 val)
		{
			RayTracingShader.SetMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, ref val);
		}

		// Token: 0x04001E30 RID: 7728
		private static readonly RayTracingShader.get_maxRecursionDepthDelegate get_maxRecursionDepthDelegateField = IL2CPP.ResolveICall<RayTracingShader.get_maxRecursionDepthDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::get_maxRecursionDepth");

		// Token: 0x04001E31 RID: 7729
		private static readonly RayTracingShader.SetFloatDelegate SetFloatDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetFloatDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetFloat");

		// Token: 0x04001E32 RID: 7730
		private static readonly RayTracingShader.SetIntDelegate SetIntDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetIntDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetInt");

		// Token: 0x04001E33 RID: 7731
		private static readonly RayTracingShader.SetFloatArrayDelegate SetFloatArrayDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetFloatArrayDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetFloatArray");

		// Token: 0x04001E34 RID: 7732
		private static readonly RayTracingShader.SetIntArrayDelegate SetIntArrayDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetIntArrayDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetIntArray");

		// Token: 0x04001E35 RID: 7733
		private static readonly RayTracingShader.SetVectorArrayDelegate SetVectorArrayDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetVectorArrayDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetVectorArray");

		// Token: 0x04001E36 RID: 7734
		private static readonly RayTracingShader.SetMatrixArrayDelegate SetMatrixArrayDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetMatrixArrayDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetMatrixArray");

		// Token: 0x04001E37 RID: 7735
		private static readonly RayTracingShader.SetTextureDelegate SetTextureDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetTextureDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetTexture");

		// Token: 0x04001E38 RID: 7736
		private static readonly RayTracingShader.SetBufferDelegate SetBufferDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetBufferDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetBuffer");

		// Token: 0x04001E39 RID: 7737
		private static readonly RayTracingShader.SetGraphicsBufferDelegate SetGraphicsBufferDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetGraphicsBufferDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetGraphicsBuffer");

		// Token: 0x04001E3A RID: 7738
		private static readonly RayTracingShader.SetConstantComputeBufferDelegate SetConstantComputeBufferDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetConstantComputeBufferDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetConstantComputeBuffer");

		// Token: 0x04001E3B RID: 7739
		private static readonly RayTracingShader.SetConstantGraphicsBufferDelegate SetConstantGraphicsBufferDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetConstantGraphicsBufferDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetConstantGraphicsBuffer");

		// Token: 0x04001E3C RID: 7740
		private static readonly RayTracingShader.SetAccelerationStructureDelegate SetAccelerationStructureDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetAccelerationStructureDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetAccelerationStructure");

		// Token: 0x04001E3D RID: 7741
		private static readonly RayTracingShader.SetShaderPassDelegate SetShaderPassDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetShaderPassDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetShaderPass");

		// Token: 0x04001E3E RID: 7742
		private static readonly RayTracingShader.SetTextureFromGlobalDelegate SetTextureFromGlobalDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetTextureFromGlobalDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetTextureFromGlobal");

		// Token: 0x04001E3F RID: 7743
		private static readonly RayTracingShader.DispatchDelegate DispatchDelegateField = IL2CPP.ResolveICall<RayTracingShader.DispatchDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::Dispatch");

		// Token: 0x04001E40 RID: 7744
		private static readonly RayTracingShader.SetVector_InjectedDelegate SetVector_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetVector_InjectedDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetVector_Injected");

		// Token: 0x04001E41 RID: 7745
		private static readonly RayTracingShader.SetMatrix_InjectedDelegate SetMatrix_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetMatrix_InjectedDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetMatrix_Injected");

		// Token: 0x02000C1D RID: 3101
		// (Invoke) Token: 0x0600368C RID: 13964
		private delegate float get_maxRecursionDepthDelegate(IntPtr @this);

		// Token: 0x02000C1E RID: 3102
		// (Invoke) Token: 0x0600368E RID: 13966
		private delegate void SetFloatDelegate(IntPtr @this, int nameID, float val);

		// Token: 0x02000C1F RID: 3103
		// (Invoke) Token: 0x06003690 RID: 13968
		private delegate void SetIntDelegate(IntPtr @this, int nameID, int val);

		// Token: 0x02000C20 RID: 3104
		// (Invoke) Token: 0x06003692 RID: 13970
		private delegate void SetFloatArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x02000C21 RID: 3105
		// (Invoke) Token: 0x06003694 RID: 13972
		private delegate void SetIntArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x02000C22 RID: 3106
		// (Invoke) Token: 0x06003696 RID: 13974
		private delegate void SetVectorArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x02000C23 RID: 3107
		// (Invoke) Token: 0x06003698 RID: 13976
		private delegate void SetMatrixArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x02000C24 RID: 3108
		// (Invoke) Token: 0x0600369A RID: 13978
		private delegate void SetTextureDelegate(IntPtr @this, int nameID, IntPtr texture);

		// Token: 0x02000C25 RID: 3109
		// (Invoke) Token: 0x0600369C RID: 13980
		private delegate void SetBufferDelegate(IntPtr @this, int nameID, IntPtr buffer);

		// Token: 0x02000C26 RID: 3110
		// (Invoke) Token: 0x0600369E RID: 13982
		private delegate void SetGraphicsBufferDelegate(IntPtr @this, int nameID, IntPtr buffer);

		// Token: 0x02000C27 RID: 3111
		// (Invoke) Token: 0x060036A0 RID: 13984
		private delegate void SetConstantComputeBufferDelegate(IntPtr @this, int nameID, IntPtr buffer, int offset, int size);

		// Token: 0x02000C28 RID: 3112
		// (Invoke) Token: 0x060036A2 RID: 13986
		private delegate void SetConstantGraphicsBufferDelegate(IntPtr @this, int nameID, IntPtr buffer, int offset, int size);

		// Token: 0x02000C29 RID: 3113
		// (Invoke) Token: 0x060036A4 RID: 13988
		private delegate void SetAccelerationStructureDelegate(IntPtr @this, int nameID, IntPtr accelerationStructure);

		// Token: 0x02000C2A RID: 3114
		// (Invoke) Token: 0x060036A6 RID: 13990
		private delegate void SetShaderPassDelegate(IntPtr @this, IntPtr passName);

		// Token: 0x02000C2B RID: 3115
		// (Invoke) Token: 0x060036A8 RID: 13992
		private delegate void SetTextureFromGlobalDelegate(IntPtr @this, int nameID, int globalTextureNameID);

		// Token: 0x02000C2C RID: 3116
		// (Invoke) Token: 0x060036AA RID: 13994
		private delegate void DispatchDelegate(IntPtr @this, IntPtr rayGenFunctionName, int width, int height, int depth, IntPtr camera);

		// Token: 0x02000C2D RID: 3117
		// (Invoke) Token: 0x060036AC RID: 13996
		private delegate void SetVector_InjectedDelegate(IntPtr @this, int nameID, IntPtr val);

		// Token: 0x02000C2E RID: 3118
		// (Invoke) Token: 0x060036AE RID: 13998
		private delegate void SetMatrix_InjectedDelegate(IntPtr @this, int nameID, IntPtr val);
	}
}
