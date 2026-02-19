const API_BASE_URL = 'http://localhost:5209';

export interface RegisterRequest {
	email: string;
	password: string;
	name: string;
}

export interface LoginRequest {
	email: string;
	password: string;
}

export interface User {
	userId: string;
	email: string;
	name: string;
}

export interface ApiResponse {
	message?: string;
	error?: string;
	user?: User;
	[userId: string]: any;
}

async function handleResponse<T>(response: Response): Promise<T> {
	if (!response.ok) {
		let errorMessage = `HTTP ${response.status}`;
		try {
			const errorData = await response.json();
			errorMessage = errorData.error || errorMessage;
		} catch {
			const text = await response.text();
			if (text) errorMessage = text;
		}
		throw new Error(errorMessage);
	}
	return response.json();
}

export async function register(data: RegisterRequest): Promise<ApiResponse> {
	try {
		const response = await fetch(`${API_BASE_URL}/auth/register`, {
			method: 'POST',
			headers: {
				'Content-Type': 'application/json',
			},
			body: JSON.stringify(data),
			credentials: 'include',
		});

		return handleResponse<ApiResponse>(response);
	} catch (err) {
		const message = err instanceof Error ? err.message : 'Network error';
		return { error: message };
	}
}

export async function login(data: LoginRequest): Promise<ApiResponse> {
	try {
		const response = await fetch(`${API_BASE_URL}/auth/login`, {
			method: 'POST',
			headers: {
				'Content-Type': 'application/json',
			},
			body: JSON.stringify(data),
			credentials: 'include',
		});

		return handleResponse<ApiResponse>(response);
	} catch (err) {
		const message = err instanceof Error ? err.message : 'Network error';
		return { error: message };
	}
}

export async function logout(): Promise<ApiResponse> {
	try {
		const response = await fetch(`${API_BASE_URL}/auth/logout`, {
			method: 'POST',
			credentials: 'include',
		});
		return handleResponse<ApiResponse>(response);
	} catch (err) {
		const message = err instanceof Error ? err.message : 'Network error';
		return { error: message };
	}
}

export async function getCurrentUser(): Promise<ApiResponse> {
	try {
		const response = await fetch(`${API_BASE_URL}/auth/me`, {
			method: 'GET',
			credentials: 'include',
		});
		return handleResponse<ApiResponse>(response);
	} catch (err) {
		const message = err instanceof Error ? err.message : 'Network error';
		return { error: message };
	}
}
