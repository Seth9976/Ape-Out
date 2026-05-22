using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x020000F7 RID: 247
	public sealed class ComputeShader : Object
	{
		// Token: 0x0600144A RID: 5194 RVA: 0x00051EC4 File Offset: 0x000500C4
		// Note: this type is marked as 'beforefieldinit'.
		static ComputeShader()
		{
			Il2CppClassPointerStore<ComputeShader>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ComputeShader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr);
			ComputeShader.NativeMethodInfoPtr_FindKernel_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100665084);
			ComputeShader.NativeMethodInfoPtr_GetKernelThreadGroupSizes_Public_Void_Int32_byref_UInt32_byref_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100665085);
			ComputeShader.HasKernelDelegateField = IL2CPP.ResolveICall<ComputeShader.HasKernelDelegate>("UnityEngine.ComputeShader::HasKernel");
			ComputeShader.SetFloatDelegateField = IL2CPP.ResolveICall<ComputeShader.SetFloatDelegate>("UnityEngine.ComputeShader::SetFloat");
			ComputeShader.SetIntDelegateField = IL2CPP.ResolveICall<ComputeShader.SetIntDelegate>("UnityEngine.ComputeShader::SetInt");
			ComputeShader.SetFloatArrayDelegateField = IL2CPP.ResolveICall<ComputeShader.SetFloatArrayDelegate>("UnityEngine.ComputeShader::SetFloatArray");
			ComputeShader.SetIntArrayDelegateField = IL2CPP.ResolveICall<ComputeShader.SetIntArrayDelegate>("UnityEngine.ComputeShader::SetIntArray");
			ComputeShader.SetVectorArrayDelegateField = IL2CPP.ResolveICall<ComputeShader.SetVectorArrayDelegate>("UnityEngine.ComputeShader::SetVectorArray");
			ComputeShader.SetMatrixArrayDelegateField = IL2CPP.ResolveICall<ComputeShader.SetMatrixArrayDelegate>("UnityEngine.ComputeShader::SetMatrixArray");
			ComputeShader.SetTextureDelegateField = IL2CPP.ResolveICall<ComputeShader.SetTextureDelegate>("UnityEngine.ComputeShader::SetTexture");
			ComputeShader.SetRenderTextureDelegateField = IL2CPP.ResolveICall<ComputeShader.SetRenderTextureDelegate>("UnityEngine.ComputeShader::SetRenderTexture");
			ComputeShader.SetTextureFromGlobalDelegateField = IL2CPP.ResolveICall<ComputeShader.SetTextureFromGlobalDelegate>("UnityEngine.ComputeShader::SetTextureFromGlobal");
			ComputeShader.Internal_SetBufferDelegateField = IL2CPP.ResolveICall<ComputeShader.Internal_SetBufferDelegate>("UnityEngine.ComputeShader::Internal_SetBuffer");
			ComputeShader.Internal_SetGraphicsBufferDelegateField = IL2CPP.ResolveICall<ComputeShader.Internal_SetGraphicsBufferDelegate>("UnityEngine.ComputeShader::Internal_SetGraphicsBuffer");
			ComputeShader.SetConstantComputeBufferDelegateField = IL2CPP.ResolveICall<ComputeShader.SetConstantComputeBufferDelegate>("UnityEngine.ComputeShader::SetConstantComputeBuffer");
			ComputeShader.SetConstantGraphicsBufferDelegateField = IL2CPP.ResolveICall<ComputeShader.SetConstantGraphicsBufferDelegate>("UnityEngine.ComputeShader::SetConstantGraphicsBuffer");
			ComputeShader.DispatchDelegateField = IL2CPP.ResolveICall<ComputeShader.DispatchDelegate>("UnityEngine.ComputeShader::Dispatch");
			ComputeShader.Internal_DispatchIndirectDelegateField = IL2CPP.ResolveICall<ComputeShader.Internal_DispatchIndirectDelegate>("UnityEngine.ComputeShader::Internal_DispatchIndirect");
			ComputeShader.Internal_DispatchIndirectGraphicsBufferDelegateField = IL2CPP.ResolveICall<ComputeShader.Internal_DispatchIndirectGraphicsBufferDelegate>("UnityEngine.ComputeShader::Internal_DispatchIndirectGraphicsBuffer");
			ComputeShader.EnableKeywordDelegateField = IL2CPP.ResolveICall<ComputeShader.EnableKeywordDelegate>("UnityEngine.ComputeShader::EnableKeyword");
			ComputeShader.DisableKeywordDelegateField = IL2CPP.ResolveICall<ComputeShader.DisableKeywordDelegate>("UnityEngine.ComputeShader::DisableKeyword");
			ComputeShader.IsKeywordEnabledDelegateField = IL2CPP.ResolveICall<ComputeShader.IsKeywordEnabledDelegate>("UnityEngine.ComputeShader::IsKeywordEnabled");
			ComputeShader.GetShaderKeywordsDelegateField = IL2CPP.ResolveICall<ComputeShader.GetShaderKeywordsDelegate>("UnityEngine.ComputeShader::GetShaderKeywords");
			ComputeShader.SetShaderKeywordsDelegateField = IL2CPP.ResolveICall<ComputeShader.SetShaderKeywordsDelegate>("UnityEngine.ComputeShader::SetShaderKeywords");
			ComputeShader.SetVector_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.SetVector_InjectedDelegate>("UnityEngine.ComputeShader::SetVector_Injected");
			ComputeShader.SetMatrix_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.SetMatrix_InjectedDelegate>("UnityEngine.ComputeShader::SetMatrix_Injected");
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x00052084 File Offset: 0x00050284
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 498411, RefRangeEnd = 498415, XrefRangeStart = 498407, XrefRangeEnd = 498411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindKernel(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_FindKernel_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x000520D4 File Offset: 0x000502D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498415, XrefRangeEnd = 498419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetKernelThreadGroupSizes(int kernelIndex, out uint x, out uint y, out uint z)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref kernelIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &x;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &y;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_GetKernelThreadGroupSizes_Public_Void_Int32_byref_UInt32_byref_UInt32_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x0000B3F7 File Offset: 0x000095F7
		public ComputeShader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x0000B400 File Offset: 0x00009600
		public bool HasKernel(string name)
		{
			return ComputeShader.HasKernelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x0000B418 File Offset: 0x00009618
		public void SetFloat(int nameID, float val)
		{
			ComputeShader.SetFloatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, val);
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x0000B42C File Offset: 0x0000962C
		public void SetInt(int nameID, int val)
		{
			ComputeShader.SetIntDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, val);
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x0000B440 File Offset: 0x00009640
		public void SetVector(int nameID, Vector4 val)
		{
			this.SetVector_Injected(nameID, ref val);
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x0000B44B File Offset: 0x0000964B
		public void SetMatrix(int nameID, Matrix4x4 val)
		{
			this.SetMatrix_Injected(nameID, ref val);
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x0000B456 File Offset: 0x00009656
		public void SetFloatArray(int nameID, Il2CppStructArray<float> values)
		{
			ComputeShader.SetFloatArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x0000B46F File Offset: 0x0000966F
		public void SetIntArray(int nameID, Il2CppStructArray<int> values)
		{
			ComputeShader.SetIntArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x0000B488 File Offset: 0x00009688
		public void SetVectorArray(int nameID, Il2CppStructArray<Vector4> values)
		{
			ComputeShader.SetVectorArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x0000B4A1 File Offset: 0x000096A1
		public void SetMatrixArray(int nameID, Il2CppStructArray<Matrix4x4> values)
		{
			ComputeShader.SetMatrixArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x0000B4BA File Offset: 0x000096BA
		public void SetTexture(int kernelIndex, int nameID, Texture texture, int mipLevel)
		{
			ComputeShader.SetTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex, nameID, IL2CPP.Il2CppObjectBaseToPtr(texture), mipLevel);
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x0000B4D6 File Offset: 0x000096D6
		public void SetRenderTexture(int kernelIndex, int nameID, RenderTexture texture, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			ComputeShader.SetRenderTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex, nameID, IL2CPP.Il2CppObjectBaseToPtr(texture), mipLevel, element);
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x0000B4F4 File Offset: 0x000096F4
		public void SetTextureFromGlobal(int kernelIndex, int nameID, int globalTextureNameID)
		{
			ComputeShader.SetTextureFromGlobalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex, nameID, globalTextureNameID);
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x0000B509 File Offset: 0x00009709
		public void Internal_SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer)
		{
			ComputeShader.Internal_SetBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex, nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer));
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x0000B523 File Offset: 0x00009723
		public void Internal_SetGraphicsBuffer(int kernelIndex, int nameID, GraphicsBuffer buffer)
		{
			ComputeShader.Internal_SetGraphicsBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex, nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer));
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x0000B53D File Offset: 0x0000973D
		public void SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer)
		{
			this.Internal_SetBuffer(kernelIndex, nameID, buffer);
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x0000B54A File Offset: 0x0000974A
		public void SetBuffer(int kernelIndex, int nameID, GraphicsBuffer buffer)
		{
			this.Internal_SetGraphicsBuffer(kernelIndex, nameID, buffer);
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x0000B557 File Offset: 0x00009757
		public void SetConstantComputeBuffer(int nameID, ComputeBuffer buffer, int offset, int size)
		{
			ComputeShader.SetConstantComputeBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer), offset, size);
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x0000B573 File Offset: 0x00009773
		public void SetConstantGraphicsBuffer(int nameID, GraphicsBuffer buffer, int offset, int size)
		{
			ComputeShader.SetConstantGraphicsBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer), offset, size);
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x0000B58F File Offset: 0x0000978F
		public void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ)
		{
			ComputeShader.DispatchDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex, threadGroupsX, threadGroupsY, threadGroupsZ);
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x0000B5A6 File Offset: 0x000097A6
		public void Internal_DispatchIndirect(int kernelIndex, ComputeBuffer argsBuffer, uint argsOffset)
		{
			ComputeShader.Internal_DispatchIndirectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex, IL2CPP.Il2CppObjectBaseToPtr(argsBuffer), argsOffset);
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x0000B5C0 File Offset: 0x000097C0
		public void Internal_DispatchIndirectGraphicsBuffer(int kernelIndex, GraphicsBuffer argsBuffer, uint argsOffset)
		{
			ComputeShader.Internal_DispatchIndirectGraphicsBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex, IL2CPP.Il2CppObjectBaseToPtr(argsBuffer), argsOffset);
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x0000B5DA File Offset: 0x000097DA
		public void EnableKeyword(string keyword)
		{
			ComputeShader.EnableKeywordDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(keyword));
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x0000B5F2 File Offset: 0x000097F2
		public void DisableKeyword(string keyword)
		{
			ComputeShader.DisableKeywordDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(keyword));
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x0000B60A File Offset: 0x0000980A
		public bool IsKeywordEnabled(string keyword)
		{
			return ComputeShader.IsKeywordEnabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(keyword));
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x00052140 File Offset: 0x00050340
		public Il2CppStringArray GetShaderKeywords()
		{
			IntPtr intPtr = ComputeShader.GetShaderKeywordsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x0000B622 File Offset: 0x00009822
		public void SetShaderKeywords(Il2CppStringArray names)
		{
			ComputeShader.SetShaderKeywordsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(names));
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06001468 RID: 5224 RVA: 0x0005216C File Offset: 0x0005036C
		// (set) Token: 0x06001469 RID: 5225 RVA: 0x0000B63A File Offset: 0x0000983A
		public Il2CppStringArray shaderKeywords
		{
			get
			{
				return this.GetShaderKeywords();
			}
			set
			{
				this.SetShaderKeywords(value);
			}
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x0000B645 File Offset: 0x00009845
		public void SetFloat(string name, float val)
		{
			this.SetFloat(Shader.PropertyToID(name), val);
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x0000B656 File Offset: 0x00009856
		public void SetInt(string name, int val)
		{
			this.SetInt(Shader.PropertyToID(name), val);
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x0000B667 File Offset: 0x00009867
		public void SetVector(string name, Vector4 val)
		{
			this.SetVector(Shader.PropertyToID(name), val);
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x0000B678 File Offset: 0x00009878
		public void SetMatrix(string name, Matrix4x4 val)
		{
			this.SetMatrix(Shader.PropertyToID(name), val);
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x0000B689 File Offset: 0x00009889
		public void SetVectorArray(string name, Il2CppStructArray<Vector4> values)
		{
			this.SetVectorArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x0000B69A File Offset: 0x0000989A
		public void SetMatrixArray(string name, Il2CppStructArray<Matrix4x4> values)
		{
			this.SetMatrixArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x0000B6AB File Offset: 0x000098AB
		public void SetFloats(string name, Il2CppStructArray<float> values)
		{
			this.SetFloatArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x0000B6BC File Offset: 0x000098BC
		public void SetFloats(string name, params float[] values)
		{
			this.SetFloats(name, new Il2CppStructArray<float>(values));
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x0000B6CB File Offset: 0x000098CB
		public void SetFloats(int nameID, Il2CppStructArray<float> values)
		{
			this.SetFloatArray(nameID, values);
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x0000B6D7 File Offset: 0x000098D7
		public void SetFloats(int nameID, params float[] values)
		{
			this.SetFloats(nameID, new Il2CppStructArray<float>(values));
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x0000B6E6 File Offset: 0x000098E6
		public void SetInts(string name, Il2CppStructArray<int> values)
		{
			this.SetIntArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x0000B6F7 File Offset: 0x000098F7
		public void SetInts(string name, params int[] values)
		{
			this.SetInts(name, new Il2CppStructArray<int>(values));
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x0000B706 File Offset: 0x00009906
		public void SetInts(int nameID, Il2CppStructArray<int> values)
		{
			this.SetIntArray(nameID, values);
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x0000B712 File Offset: 0x00009912
		public void SetInts(int nameID, params int[] values)
		{
			this.SetInts(nameID, new Il2CppStructArray<int>(values));
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x0000B721 File Offset: 0x00009921
		public void SetBool(string name, bool val)
		{
			this.SetInt(Shader.PropertyToID(name), val ? 1 : 0);
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x0000B738 File Offset: 0x00009938
		public void SetBool(int nameID, bool val)
		{
			this.SetInt(nameID, val ? 1 : 0);
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x0000B74A File Offset: 0x0000994A
		public void SetTexture(int kernelIndex, int nameID, Texture texture)
		{
			this.SetTexture(kernelIndex, nameID, texture, 0);
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x0000B758 File Offset: 0x00009958
		public void SetTexture(int kernelIndex, string name, Texture texture)
		{
			this.SetTexture(kernelIndex, Shader.PropertyToID(name), texture, 0);
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x0000B76B File Offset: 0x0000996B
		public void SetTexture(int kernelIndex, string name, Texture texture, int mipLevel)
		{
			this.SetTexture(kernelIndex, Shader.PropertyToID(name), texture, mipLevel);
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x0000B77F File Offset: 0x0000997F
		public void SetTexture(int kernelIndex, int nameID, RenderTexture texture, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			this.SetRenderTexture(kernelIndex, nameID, texture, mipLevel, element);
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x0000B790 File Offset: 0x00009990
		public void SetTexture(int kernelIndex, string name, RenderTexture texture, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			this.SetRenderTexture(kernelIndex, Shader.PropertyToID(name), texture, mipLevel, element);
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x0000B7A6 File Offset: 0x000099A6
		public void SetTextureFromGlobal(int kernelIndex, string name, string globalTextureName)
		{
			this.SetTextureFromGlobal(kernelIndex, Shader.PropertyToID(name), Shader.PropertyToID(globalTextureName));
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x0000B7BD File Offset: 0x000099BD
		public void SetBuffer(int kernelIndex, string name, ComputeBuffer buffer)
		{
			this.SetBuffer(kernelIndex, Shader.PropertyToID(name), buffer);
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x0000B7CF File Offset: 0x000099CF
		public void SetBuffer(int kernelIndex, string name, GraphicsBuffer buffer)
		{
			this.SetBuffer(kernelIndex, Shader.PropertyToID(name), buffer);
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x0000B7E1 File Offset: 0x000099E1
		public void SetConstantBuffer(int nameID, ComputeBuffer buffer, int offset, int size)
		{
			this.SetConstantComputeBuffer(nameID, buffer, offset, size);
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x0000B7F0 File Offset: 0x000099F0
		public void SetConstantBuffer(string name, ComputeBuffer buffer, int offset, int size)
		{
			this.SetConstantBuffer(Shader.PropertyToID(name), buffer, offset, size);
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x0000B804 File Offset: 0x00009A04
		public void SetConstantBuffer(int nameID, GraphicsBuffer buffer, int offset, int size)
		{
			this.SetConstantGraphicsBuffer(nameID, buffer, offset, size);
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x0000B813 File Offset: 0x00009A13
		public void SetConstantBuffer(string name, GraphicsBuffer buffer, int offset, int size)
		{
			this.SetConstantBuffer(Shader.PropertyToID(name), buffer, offset, size);
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x00052184 File Offset: 0x00050384
		public void DispatchIndirect(int kernelIndex, ComputeBuffer argsBuffer, uint argsOffset)
		{
			bool flag = argsBuffer == null;
			if (flag)
			{
				throw new ArgumentNullException("argsBuffer");
			}
			bool flag2 = argsBuffer.m_Ptr == IntPtr.Zero;
			if (flag2)
			{
				throw new ObjectDisposedException("argsBuffer");
			}
			this.Internal_DispatchIndirect(kernelIndex, argsBuffer, argsOffset);
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x0000B827 File Offset: 0x00009A27
		public void DispatchIndirect(int kernelIndex, ComputeBuffer argsBuffer)
		{
			this.DispatchIndirect(kernelIndex, argsBuffer, 0U);
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x0000B834 File Offset: 0x00009A34
		public void DispatchIndirect(int kernelIndex, GraphicsBuffer argsBuffer, uint argsOffset)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x0000B841 File Offset: 0x00009A41
		public void DispatchIndirect(int kernelIndex, GraphicsBuffer argsBuffer)
		{
			this.DispatchIndirect(kernelIndex, argsBuffer, 0U);
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x0000B84E File Offset: 0x00009A4E
		public void SetVector_Injected(int nameID, ref Vector4 val)
		{
			ComputeShader.SetVector_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, ref val);
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x0000B862 File Offset: 0x00009A62
		public void SetMatrix_Injected(int nameID, ref Matrix4x4 val)
		{
			ComputeShader.SetMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, ref val);
		}

		// Token: 0x04001006 RID: 4102
		private static readonly IntPtr NativeMethodInfoPtr_FindKernel_Public_Int32_String_0;

		// Token: 0x04001007 RID: 4103
		private static readonly IntPtr NativeMethodInfoPtr_GetKernelThreadGroupSizes_Public_Void_Int32_byref_UInt32_byref_UInt32_byref_UInt32_0;

		// Token: 0x04001008 RID: 4104
		private static readonly ComputeShader.HasKernelDelegate HasKernelDelegateField;

		// Token: 0x04001009 RID: 4105
		private static readonly ComputeShader.SetFloatDelegate SetFloatDelegateField;

		// Token: 0x0400100A RID: 4106
		private static readonly ComputeShader.SetIntDelegate SetIntDelegateField;

		// Token: 0x0400100B RID: 4107
		private static readonly ComputeShader.SetFloatArrayDelegate SetFloatArrayDelegateField;

		// Token: 0x0400100C RID: 4108
		private static readonly ComputeShader.SetIntArrayDelegate SetIntArrayDelegateField;

		// Token: 0x0400100D RID: 4109
		private static readonly ComputeShader.SetVectorArrayDelegate SetVectorArrayDelegateField;

		// Token: 0x0400100E RID: 4110
		private static readonly ComputeShader.SetMatrixArrayDelegate SetMatrixArrayDelegateField;

		// Token: 0x0400100F RID: 4111
		private static readonly ComputeShader.SetTextureDelegate SetTextureDelegateField;

		// Token: 0x04001010 RID: 4112
		private static readonly ComputeShader.SetRenderTextureDelegate SetRenderTextureDelegateField;

		// Token: 0x04001011 RID: 4113
		private static readonly ComputeShader.SetTextureFromGlobalDelegate SetTextureFromGlobalDelegateField;

		// Token: 0x04001012 RID: 4114
		private static readonly ComputeShader.Internal_SetBufferDelegate Internal_SetBufferDelegateField;

		// Token: 0x04001013 RID: 4115
		private static readonly ComputeShader.Internal_SetGraphicsBufferDelegate Internal_SetGraphicsBufferDelegateField;

		// Token: 0x04001014 RID: 4116
		private static readonly ComputeShader.SetConstantComputeBufferDelegate SetConstantComputeBufferDelegateField;

		// Token: 0x04001015 RID: 4117
		private static readonly ComputeShader.SetConstantGraphicsBufferDelegate SetConstantGraphicsBufferDelegateField;

		// Token: 0x04001016 RID: 4118
		private static readonly ComputeShader.DispatchDelegate DispatchDelegateField;

		// Token: 0x04001017 RID: 4119
		private static readonly ComputeShader.Internal_DispatchIndirectDelegate Internal_DispatchIndirectDelegateField;

		// Token: 0x04001018 RID: 4120
		private static readonly ComputeShader.Internal_DispatchIndirectGraphicsBufferDelegate Internal_DispatchIndirectGraphicsBufferDelegateField;

		// Token: 0x04001019 RID: 4121
		private static readonly ComputeShader.EnableKeywordDelegate EnableKeywordDelegateField;

		// Token: 0x0400101A RID: 4122
		private static readonly ComputeShader.DisableKeywordDelegate DisableKeywordDelegateField;

		// Token: 0x0400101B RID: 4123
		private static readonly ComputeShader.IsKeywordEnabledDelegate IsKeywordEnabledDelegateField;

		// Token: 0x0400101C RID: 4124
		private static readonly ComputeShader.GetShaderKeywordsDelegate GetShaderKeywordsDelegateField;

		// Token: 0x0400101D RID: 4125
		private static readonly ComputeShader.SetShaderKeywordsDelegate SetShaderKeywordsDelegateField;

		// Token: 0x0400101E RID: 4126
		private static readonly ComputeShader.SetVector_InjectedDelegate SetVector_InjectedDelegateField;

		// Token: 0x0400101F RID: 4127
		private static readonly ComputeShader.SetMatrix_InjectedDelegate SetMatrix_InjectedDelegateField;

		// Token: 0x020007D9 RID: 2009
		// (Invoke) Token: 0x06002DB4 RID: 11700
		private delegate bool HasKernelDelegate(IntPtr @this, IntPtr name);

		// Token: 0x020007DA RID: 2010
		// (Invoke) Token: 0x06002DB6 RID: 11702
		private delegate void SetFloatDelegate(IntPtr @this, int nameID, float val);

		// Token: 0x020007DB RID: 2011
		// (Invoke) Token: 0x06002DB8 RID: 11704
		private delegate void SetIntDelegate(IntPtr @this, int nameID, int val);

		// Token: 0x020007DC RID: 2012
		// (Invoke) Token: 0x06002DBA RID: 11706
		private delegate void SetFloatArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x020007DD RID: 2013
		// (Invoke) Token: 0x06002DBC RID: 11708
		private delegate void SetIntArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x020007DE RID: 2014
		// (Invoke) Token: 0x06002DBE RID: 11710
		private delegate void SetVectorArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x020007DF RID: 2015
		// (Invoke) Token: 0x06002DC0 RID: 11712
		private delegate void SetMatrixArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x020007E0 RID: 2016
		// (Invoke) Token: 0x06002DC2 RID: 11714
		private delegate void SetTextureDelegate(IntPtr @this, int kernelIndex, int nameID, IntPtr texture, int mipLevel);

		// Token: 0x020007E1 RID: 2017
		// (Invoke) Token: 0x06002DC4 RID: 11716
		private delegate void SetRenderTextureDelegate(IntPtr @this, int kernelIndex, int nameID, IntPtr texture, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);

		// Token: 0x020007E2 RID: 2018
		// (Invoke) Token: 0x06002DC6 RID: 11718
		private delegate void SetTextureFromGlobalDelegate(IntPtr @this, int kernelIndex, int nameID, int globalTextureNameID);

		// Token: 0x020007E3 RID: 2019
		// (Invoke) Token: 0x06002DC8 RID: 11720
		private delegate void Internal_SetBufferDelegate(IntPtr @this, int kernelIndex, int nameID, IntPtr buffer);

		// Token: 0x020007E4 RID: 2020
		// (Invoke) Token: 0x06002DCA RID: 11722
		private delegate void Internal_SetGraphicsBufferDelegate(IntPtr @this, int kernelIndex, int nameID, IntPtr buffer);

		// Token: 0x020007E5 RID: 2021
		// (Invoke) Token: 0x06002DCC RID: 11724
		private delegate void SetConstantComputeBufferDelegate(IntPtr @this, int nameID, IntPtr buffer, int offset, int size);

		// Token: 0x020007E6 RID: 2022
		// (Invoke) Token: 0x06002DCE RID: 11726
		private delegate void SetConstantGraphicsBufferDelegate(IntPtr @this, int nameID, IntPtr buffer, int offset, int size);

		// Token: 0x020007E7 RID: 2023
		// (Invoke) Token: 0x06002DD0 RID: 11728
		private delegate void DispatchDelegate(IntPtr @this, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);

		// Token: 0x020007E8 RID: 2024
		// (Invoke) Token: 0x06002DD2 RID: 11730
		private delegate void Internal_DispatchIndirectDelegate(IntPtr @this, int kernelIndex, IntPtr argsBuffer, uint argsOffset);

		// Token: 0x020007E9 RID: 2025
		// (Invoke) Token: 0x06002DD4 RID: 11732
		private delegate void Internal_DispatchIndirectGraphicsBufferDelegate(IntPtr @this, int kernelIndex, IntPtr argsBuffer, uint argsOffset);

		// Token: 0x020007EA RID: 2026
		// (Invoke) Token: 0x06002DD6 RID: 11734
		private delegate void EnableKeywordDelegate(IntPtr @this, IntPtr keyword);

		// Token: 0x020007EB RID: 2027
		// (Invoke) Token: 0x06002DD8 RID: 11736
		private delegate void DisableKeywordDelegate(IntPtr @this, IntPtr keyword);

		// Token: 0x020007EC RID: 2028
		// (Invoke) Token: 0x06002DDA RID: 11738
		private delegate bool IsKeywordEnabledDelegate(IntPtr @this, IntPtr keyword);

		// Token: 0x020007ED RID: 2029
		// (Invoke) Token: 0x06002DDC RID: 11740
		private delegate IntPtr GetShaderKeywordsDelegate(IntPtr @this);

		// Token: 0x020007EE RID: 2030
		// (Invoke) Token: 0x06002DDE RID: 11742
		private delegate void SetShaderKeywordsDelegate(IntPtr @this, IntPtr names);

		// Token: 0x020007EF RID: 2031
		// (Invoke) Token: 0x06002DE0 RID: 11744
		private delegate void SetVector_InjectedDelegate(IntPtr @this, int nameID, IntPtr val);

		// Token: 0x020007F0 RID: 2032
		// (Invoke) Token: 0x06002DE2 RID: 11746
		private delegate void SetMatrix_InjectedDelegate(IntPtr @this, int nameID, IntPtr val);
	}
}
